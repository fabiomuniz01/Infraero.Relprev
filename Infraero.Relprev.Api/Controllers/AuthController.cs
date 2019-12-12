using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraero.Relprev.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Infraero.Relprev.Api.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : ApiController
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly AppSettings _appSettings;

        public AuthController(SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager,
            IOptions<AppSettings> appSettings)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _appSettings = appSettings.Value;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUsuarioVm registerUsuarioVm)
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
                    Email = registerUsuarioVm.Email,
                    EmailConfirmed = true
                };

                var result = await _userManager.CreateAsync(user, registerUsuarioVm.Password);

                if (!result.Succeeded)
                {
                    return BadRequest(result.Errors);
                }

                await _signInManager.SignInAsync(user, false);

                return Ok(await GerarJwt(registerUsuarioVm.Email));
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioVm loginUsuarioVm)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
                }

                var result = await _signInManager.PasswordSignInAsync(loginUsuarioVm.Email, loginUsuarioVm.Password, false, true);

                if (result.Succeeded)
                {
                    return Ok(await GerarJwt(loginUsuarioVm.Email));
                }

                return BadRequest("Usuário não cadastrado.");

                return Ok();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private async Task<string> GerarJwt(string usuario)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(usuario);

                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_appSettings.Secret);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Issuer = _appSettings.Emissor,
                    Audience = _appSettings.ValidoEm,
                    Expires = DateTime.UtcNow.AddHours(_appSettings.ExpiracaoHoras),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha256Signature)

                };

                return tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}