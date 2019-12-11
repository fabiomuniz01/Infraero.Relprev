using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.Api.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : ApiController
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AuthController(SignInManager<IdentityUser> signInManager, 
            UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(IdentityVm.RegisterUsuarioVm registerUsuarioVm)
        {
            try
            {
                if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
            }

            var user = new IdentityUser
            {
                UserName = registerUsuarioVm.Email,
                Email = registerUsuarioVm.Senha,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, registerUsuarioVm.Senha);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            await _signInManager.SignInAsync(user, false);

            return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            

        }
    }
}