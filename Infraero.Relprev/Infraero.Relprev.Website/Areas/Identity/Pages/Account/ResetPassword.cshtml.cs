﻿using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Infraero.Relprev.Data.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Infraero.Relprev.Website.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ResetPasswordModel : PageModel
    {
        private readonly UserManager<WebProfileUser> _userManager;

        public ResetPasswordModel(UserManager<WebProfileUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty] public InputModel Input { get; set; }

        public IActionResult OnGet(string code = null)
        {
            if (code == null)
            {
                return BadRequest("A code must be supplied for password reset.");
            }

            Input = new InputModel
            {
                Code = code
            };
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Usuário não cadastrado.");
                return Page();
            }


            var result = await _userManager.ResetPasswordAsync(user, Input.Code, Input.Password);
            if (result.Succeeded) return RedirectToPage("./ResetPasswordConfirmation");

            foreach (var error in result.Errors) ModelState.AddModelError(string.Empty, error.Description);
            return Page();
        }

        public class InputModel
        {
            [Required]
            [RegularExpression(@"^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\-+)|([A-Za-z0-9]+\.+)|([A-Za-z0-9]+\++))*[A-Za-z0-9]+@((\w+\-+)|(\w+\.))*\w{1,63}\.[a-zA-Z]{2,6}$", ErrorMessage = "O e-mail informado deve atender um formato padrão válido.")]
            [EmailAddress] public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "Formato de senha inválido, a senha deve conter no mínimo 8 digitos.",
                MinimumLength = 8)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")] [Compare("Password", ErrorMessage = "A senha e a senha de confirmação não coincidem.")]
            public string ConfirmPassword { get; set; }

            public string Code { get; set; }
        }
    }
}