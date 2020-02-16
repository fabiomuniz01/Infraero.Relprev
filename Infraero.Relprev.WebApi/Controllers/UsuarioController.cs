using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Usuario.Commands.CreateUsuario;
using Infraero.Relprev.Application.Usuario.Commands.DeleteUsuario;
using Infraero.Relprev.Application.Usuario.Commands.UpdateUsuario;
using Infraero.Relprev.Application.Usuario.Queries.GetUsuarios;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : ApiController
    {
        private readonly ApplicationDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<WebProfileUser> _userManager;
            
        public UsuarioController(ApplicationDbContext db, RoleManager<IdentityRole> roleManager, UserManager<WebProfileUser> userManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [HttpPost("CreateUsuario")]
        public async Task<IdentityResult> CreateUsuario(CreateUsuarioCommand command)
        {
            try
            {
                var result = new IdentityResult();

                var user = new WebProfileUser
                {
                    DateRegistered = DateTime.UtcNow,
                    UserName = command.UserName,
                    Email = command.Email,
                    Nome = command.Nome,
                    Cpf = command.Cpf,
                    Telefone = command.Telefone
                };

                var existingUser = await _userManager.FindByEmailAsync(user.UserName);
                if (existingUser != null)
                {
                    ModelState.AddModelError(string.Empty, "Usuario informado já está cadastrado.");
                }

                // Create the user in the database
                result = await _userManager.CreateAsync(user, "12345678");
                var userRole = _db.Roles.FirstOrDefault(x => x.Id == command.CodPerfil).Name;
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, userRole);
                    command.Id = user.Id;
                    var resultUsu = await Mediator.Send(command);

                }

                foreach (var error in result.Errors) ModelState.AddModelError(string.Empty, error.Description);

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetGridUsuario")]
        public async Task<GridUsuario> GetGridUsuario()
        {
            try
            {
                var responseModel = _userManager.Users;
                var userRoles = _db.UserRoles;
                var roles = _db.Roles;

                var list = responseModel.Select(item => new UsuarioDto
                {
                    NomUsuario = item.Nome, NumCpf = item.Cpf, DscEmail = item.Email,
                    DscPerfil = roles
                        .Where(x => x.Id == userRoles.Where(s => s.UserId == item.Id).Select(s => s.RoleId)
                                        .FirstOrDefault()).Select(s => s.Name).FirstOrDefault()
                }).ToList();

                var grid = new GridUsuario
                {
                    aaData = list,
                    sEcho = 0,
                    iTotalRecords = responseModel.Count(),
                    recordsFiltered = responseModel.Count(),
                    iTotalDisplayRecords = 1
                };

                return grid;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetUsuarioById/{id}")]
        public async Task<UsuarioDto> GetUsuarioById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetUsuarioByIdQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


        [HttpPost("UpdateUsuario")]
        public async Task<ActionResult<bool>> UpdateUsuario(UpdateUsuarioCommand command)
        {
            try
            {
                var result = await Mediator.Send(command);

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteUsuario(int id)
        {
            try
            {
                var result = await Mediator.Send(new DeleteUsuarioCommand { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost("GetUsuarioByCpf")]
        public async Task<UsuarioDto> GetUsuarioByCpf([FromBody]string cpf)
        {
            try
            {
                var result =  _db.Users.FirstOrDefault(user => user.Cpf == cpf);
                return await Task.FromResult(result ==null? new UsuarioDto() : new UsuarioDto {CodUsuario = result.Id});
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


    }
}