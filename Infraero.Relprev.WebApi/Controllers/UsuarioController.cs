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
        public async Task<ActionResult<long>> CreateUsuario(CreateUsuarioCommand command)
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
                long resultUsu = 0;
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, userRole);
                    command.Id = user.Id;
                    command.NomUsuario = user.Nome;
                    command.NumCpf = user.Cpf;
                    command.NumTelefone = user.Telefone;
                    command.DthRegistro = user.DateRegistered.ToString();
                    command.Email = user.Email;
                    command.NomPerfil = userRole;

                    resultUsu = await Mediator.Send(command);

                }

                foreach (var error in result.Errors) ModelState.AddModelError(string.Empty, error.Description);

                return resultUsu;
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
                var resultUsu = false;
                var user = await _userManager.FindByEmailAsync(command.Email);

                if (user != null)
                {
                    user.Nome = command.NomUsuario;
                    user.PhoneNumber = command.NumTelefone;

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(new WebProfileUser {Id = user.Id});

                        var rsRemove = await _userManager.RemoveFromRoleAsync(user,userRoles.FirstOrDefault());

                        if (!rsRemove.Succeeded) return resultUsu;
                        var userRole = _db.Roles.FirstOrDefault(x => x.Id == command.CodPerfil).Name;
                        await _userManager.AddToRoleAsync(user, userRole);
                        command.Id = user.Id;
                        resultUsu = await Mediator.Send(command);
                    }
                }
                return resultUsu;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost("DeleteUsuario")]
        public async Task<ActionResult<bool>> DeleteUsuario(DeleteUsuarioCommand command)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(command.Id);

                if (user==null)
                {
                    throw new Exception(
                        "Usuário não encontrado.");
                }

                var resultDelete = _userManager.DeleteAsync(user);

                var result = false;
                if (resultDelete.Result.Succeeded)
                {
                    result = await Mediator.Send(command);

                }

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
                    NomUsuario = item.Nome, NumCpf = item.Cpf, Email = item.Email, CodUsuarioLogin = item.Id,
                    NomPerfil = roles
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
        public async Task<UsuarioDto> GetUsuarioById(string id)
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

        [HttpGet("GetUsuarioByName/{name}")]
        public async Task<WebProfileUser> GetUsuarioByName(string name)
        {
            try
            {
                var result = await _userManager.FindByEmailAsync(name);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpPost("GetUsuarioByCpf")]
        public async Task<bool> GetUsuarioByCpf([FromBody]string cpf)
        {
            try
            {
                var result = _db.Users.Where(user => user.Cpf == cpf).Any();
                return result;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        [HttpGet("GetUsuarioByEmail")]
        public async Task<bool> GetUsuarioByEmail(string email)
        {
            try
            {
                var result =  _db.Users.Where(user => user.Email == email).Any();
                return result;
            }
            catch (Exception e)
            {
                throw;
            }
        }


    }
}