﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.Infrastructure.Persistence;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Infraero.Relprev.WebUi.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly IEmailSender _emailSender;
        private readonly IHostingEnvironment _host;
        private readonly ILogger<LoginModel> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<WebProfileUser> _signInManager;
        private readonly UserManager<WebProfileUser> _userManager;

        public LoginModel(UserManager<WebProfileUser> userManager,
            SignInManager<WebProfileUser> signInManager,
            ILogger<LoginModel> logger,
            IEmailSender emailSender,
            IHostingEnvironment host,
            ApplicationDbContext db,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _host = host;
            _db = db;
            _roleManager = roleManager;
            ConfirmEmailSent = false;
        }

        [BindProperty] public LoginInput Login { get; set; }

        [BindProperty] public RegisterInput Register { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public bool ConfirmEmailSent { get; set; }

        public string ReturnUrl { get; set; }

        [TempData] public string ErrorMessage { get; set; }


        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage)) ModelState.AddModelError(string.Empty, ErrorMessage);

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostRegisterAsync(string returnUrl = null)
        {
            ConfirmEmailSent = false;

            if (ModelState.IsValid)
            {
                var user = new WebProfileUser
                {
                    DateRegistered = DateTime.UtcNow,
                    UserName = Register.Email,
                    Email = Register.Email,
                    Nome = Register.FirstName,
                    Cpf = Register.LastName,
                };

                // If there is already a user in the system with this email, and they have not confirmed thier email
                // send them a new confirmation email rather than trying to register them.
                var existingUser = await _userManager.FindByEmailAsync(user.UserName);
                if (existingUser != null && !existingUser.EmailConfirmed)
                {
                    await SendEmailConfirmation(existingUser);
                    return Page();
                }

                // Create the user in the database
                var result = await _userManager.CreateAsync(user, Register.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("O usuário criou uma nova conta com senha.");

                    // Setup database roles
                    //var userCount = _db.Users.Count();
                    var roleCount = _db.Roles.Count();

                    // NOTE: This is not necessarily best practice at all.
                    // First registered user will add the default roles, rather than doing this in a migration.
                    // First registered user will be given all roles.
                    if (roleCount == 0)
                    {
                        await _roleManager.CreateAsync(new IdentityRole { Name = UserRoles.Administrator });

                        // set this registering user as admin/everything
                        await _userManager.AddToRolesAsync(user,
                            new[] { UserRoles.Administrator });
                    }

                    await _userManager.AddToRoleAsync(user, UserRoles.Registered);
                    await SendEmailConfirmation(user);

                    // If you want to login the user without awaiting email confirmation, uncomment this line.
                    //await _signInManager.SignInAsync(user, isPersistent: false);
                    return Page();
                }

                foreach (var error in result.Errors) ModelState.AddModelError(string.Empty, error.Description);
            }


            // If we got this far, something failed, redisplay form
            return Page();
        }

        private async Task SendEmailConfirmation(WebProfileUser user)
        {
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                null,
                new { userId = user.Id, code },
                Request.Scheme);

            var message =
                System.IO.File.ReadAllText(Path.Combine(_host.WebRootPath, "emailtemplates/ConfirmEmail.html"));
            message = message.Replace("%NAME%", Register.FirstName);
            message = message.Replace("%CALLBACK%", HtmlEncoder.Default.Encode(callbackUrl));

            await _emailSender.SendEmailAsync(Register.Email, "Confirm Your Admin Portal Registration",
                message);

            ConfirmEmailSent = true;
        }

        public async Task<IActionResult> OnPostLoginAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager.PasswordSignInAsync(Login.Email, Login.Password, Login.RememberMe, true);

                var u = await _userManager.FindByEmailAsync(Login.Email);

                if (u==null)
                {
                    ModelState.AddModelError(string.Empty, "Usuário não cadastrado.");
                    return Page();
                }

                if (!result.Succeeded)
                {
                    if (result.IsLockedOut)
                    {
                        _logger.LogWarning("A sua conta foi bloqueada.");
                        ModelState.AddModelError(string.Empty, "A sua conta foi bloqueada.");
                        return RedirectToPage("./ForgotPassword");
                    }

                    ModelState.AddModelError(string.Empty, "Senha inválida.");
                    return Page();
                }

                if (result.Succeeded)
                {
                    if (!u.FirstAccess.HasValue)
                    {
                        _logger.LogInformation("Primeiro acesso do usuário.");

                        var code = await _userManager.GeneratePasswordResetTokenAsync(u);
                        var email = Login.Email;
                        var callbackUrl = Url.Page(
                            "/Account/FirstAccessPassword",
                            null,
                            new { email, code },
                            Request.Scheme);

                        return RedirectToPage("./FirstAccessPassword", new { email, code });
                    }
                    //await _userManager.AddClaimAsync(u, new Claim(ClaimTypes.Upn, u.Cpf));

                    _logger.LogInformation("User logged in.");
                        return LocalRedirect(returnUrl);
                }
            }
            return Page();
        }


        public class LoginInput : IValidatableObject
        {
            [RegularExpression(@"^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\-+)|([A-Za-z0-9]+\.+)|([A-Za-z0-9]+\++))*[A-Za-z0-9]+@((\w+\-+)|(\w+\.))*\w{1,63}\.[a-zA-Z]{2,6}$", ErrorMessage = "O e-mail informado deve atender um formato padrão válido.")]
            public string Email { get; set; }

            [DataType(DataType.Password)] public string Password { get; set; }

            [Display(Name = "Remember me?")] public bool RememberMe { get; set; }

            public bool Submitted { get; set; } = false;

            public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            {
                var results = new List<ValidationResult>();

                if (Submitted)
                {
                    if (string.IsNullOrEmpty(Email))
                        results.Add(new ValidationResult("Your email address is required", new[] { "Email" }));

                    if (string.IsNullOrEmpty(Password))
                        results.Add(new ValidationResult("Your password is required", new[] { "Password" }));
                }

                return results;
            }
        }

        public class RegisterInput : IValidatableObject
        {
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
                MinimumLength = 1)]
            public string Company { get; set; }

            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
                MinimumLength = 1)]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
                MinimumLength = 1)]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }


            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
                MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required] public bool AgreeTerms { get; set; }

            public bool Submitted { get; set; } = false;

            public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            {
                var results = new List<ValidationResult>();

                if (Submitted)
                {
                    if (string.IsNullOrWhiteSpace(Email))
                        results.Add(new ValidationResult("Your email address is required", new[] { "Email" }));

                    if (string.IsNullOrWhiteSpace(Password))
                        results.Add(new ValidationResult("Your password is required", new[] { "Password" }));

                    if (ConfirmPassword != Password)
                        results.Add(new ValidationResult("Your passwords should match",
                            new[] { "Password", "ConfirmPassword" }));

                    if (string.IsNullOrWhiteSpace(FirstName))
                        results.Add(new ValidationResult("Your First Name is required", new[] { "FirstName" }));

                    if (string.IsNullOrWhiteSpace(LastName))
                        results.Add(new ValidationResult("Your Last Name is required", new[] { "LastName" }));

                    if (!AgreeTerms)
                        results.Add(new ValidationResult("You really should agree to the Terms and Conditions",
                            new[] { "AgreeTerms" }));
                }

                return results;
            }
        }
    }
}