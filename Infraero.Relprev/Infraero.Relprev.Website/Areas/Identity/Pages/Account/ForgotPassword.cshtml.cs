﻿using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Infraero.Relprev.Data.EntityFramework;
using Infraero.Relprev.Data.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Infraero.Relprev.Website.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ForgotPasswordModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly IEmailSender _emailSender;
        private readonly IHostingEnvironment _host;
        private readonly UserManager<WebProfileUser> _userManager;

        public ForgotPasswordModel(UserManager<WebProfileUser> userManager, IEmailSender emailSender,
            IHostingEnvironment host,
            ApplicationDbContext db)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _host = host;
            _db = db;
        }

        [BindProperty] public InputModel Input { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Usuário não cadastrado.");
                    return Page();
                }
                //|| !await _userManager.IsEmailConfirmedAsync(user))
                    // Don't reveal that the user does not exist or is not confirmed
                    //return RedirectToPage("./ForgotPasswordConfirmation");

                await SendForgotPasswordEmail(user);

                return RedirectToPage("./ForgotPasswordConfirmation");
            }

            return Page();
        }

        private async Task SendForgotPasswordEmail(WebProfileUser user)
        {
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callbackUrl = Url.Page(
                "/Account/ResetPassword",
                null,
                new { code },
                Request.Scheme);


            var message =
                System.IO.File.ReadAllText(Path.Combine(_host.WebRootPath, "emailtemplates/ForgotPassword.html"));
            message = message.Replace("%NAME%", user.FirstName);
            message = message.Replace("%CALLBACK%", HtmlEncoder.Default.Encode(callbackUrl));





            await _emailSender.SendEmailAsync(user.Email, "Recupere sua senha do sistema Relprev",
                message);
        }

        public class InputModel
        {
            [Required]
            [RegularExpression(@"^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\-+)|([A-Za-z0-9]+\.+)|([A-Za-z0-9]+\++))*[A-Za-z0-9]+@((\w+\-+)|(\w+\.))*\w{1,63}\.[a-zA-Z]{2,6}$", ErrorMessage = "O e-mail informado deve atender um formato padrão válido.")]
            public string Email { get; set; }
        }
    }
}