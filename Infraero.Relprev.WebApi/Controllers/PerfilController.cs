using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Modulo.Queries.GetModulos;
using Infraero.Relprev.Application.Perfil.Commands.CreatePerfil;
using Infraero.Relprev.Application.Perfil.Commands.DeletePerfil;
using Infraero.Relprev.Application.Perfil.Commands.UpdatePerfil;
using Infraero.Relprev.Application.Perfil.Queries.GetPerfils;
using Infraero.Relprev.Application.Usuario.Commands.UpdateUsuario;
using Infraero.Relprev.Application.Usuario.Queries.GetUsuarios;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class PerfilController : ApiController
    {
        private readonly ApplicationDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<WebProfileUser> _userManager;

        public PerfilController(ApplicationDbContext db, RoleManager<IdentityRole> roleManager, UserManager<WebProfileUser> userManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [HttpPost("CreatePerfil")]
        public async Task<ActionResult<long>> CreatePerfil(CreatePerfilCommand command)
        {
            try
            {
                var adminRole = await _roleManager.FindByNameAsync(command.NomPerfil);
                var result = false;
                if (adminRole == null)
                {
                    adminRole = new IdentityRole(command.NomPerfil);
                    await _roleManager.CreateAsync(adminRole);
                    foreach (DictionaryEntry claim in command.ListClaim)
                    {
                        var addClaim = new Claim(claim.Key.ToString(), claim.Value.ToString());
                        await _roleManager.AddClaimAsync(adminRole, addClaim);
                    }

                    result = true;
                }

                return result?1:0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("GetGridPerfil")]
        public async Task<GridPerfil> GetGridPerfil()
        {
            try
            {
                var responseModel = _db.Roles;

                var list = responseModel.Select(s => s).ToList().Select(item => new PerfilDto { NomPerfil = item.Name, CodPerfil = item.Id }).ToList();
                var grid = new GridPerfil
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

        [HttpGet("GetPerfilById/{id}")]
        public async Task<PerfilDto> GetPerfilById(string id)
        {
            try
            {
                var entity = _db.Roles.Where(x => x.Id == id).Select(item => new PerfilDto { NomPerfil = item.Name, CodPerfil = item.Id }).FirstOrDefault();
                var role = _roleManager.Roles.Single(x => x.Id == entity.CodPerfil);
                var claims = _roleManager.GetClaimsAsync(role).Result;
                ListDictionary list = new ListDictionary();
                foreach (var claim in claims)
                {
                    list.Add(claim.Type,claim.Value);
                }

                entity.ListClaims = list;
                return entity;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost("UpdatePerfil")]
        public async Task<ActionResult<bool>> UpdatePerfil(UpdatePerfilCommand command)
        {
            try
            {
                var result = false;
                
                var adminRole = await _roleManager.FindByIdAsync(command.CodPerfil);

                if (adminRole != null)
                {
                    adminRole.Name = command.NomPerfil;
                    var resRole = await _roleManager.UpdateAsync(adminRole);

                    var role = _roleManager.Roles.Single(x => x.Id == command.CodPerfil);
                    var claims = _roleManager.GetClaimsAsync(role).Result;

                    foreach (var claim in claims)
                    {
                        var res = await _roleManager.RemoveClaimAsync(adminRole, claim);
                    }

                    foreach (DictionaryEntry claim in command.ListClaim)
                    {
                        var addClaim = new Claim(claim.Key.ToString(), claim.Value.ToString());
                        var res = await _roleManager.AddClaimAsync(adminRole, addClaim);
                    }

                    result = true;
                }

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpPost("DeletePerfil")]
        public async Task<ActionResult<bool>> DeletePerfil(DeletePerfilCommand command)
        {
            try
            {
                var obj = _db.Roles.Where(x => x.Id == command.CodPerfil).FirstOrDefault();

                var usersInRole =
                    _db.UserRoles.Where(u => u.RoleId == command.CodPerfil).Select(s => s.UserId);

                foreach (var id in usersInRole)
                {
                    var user = await _userManager.FindByIdAsync(id);
                    if (user != null)
                    {
                            var userRoles = await _userManager.GetRolesAsync(new WebProfileUser { Id = user.Id });

                            var rsRemove = await _userManager.RemoveFromRoleAsync(user, userRoles.FirstOrDefault());

                            if (!rsRemove.Succeeded) return null;
                            var userRole = _db.Roles.FirstOrDefault(x => x.Name.ToUpper() == command.NomPerfilUsuarioPublico.ToUpper());
                            await _userManager.AddToRoleAsync(user, userRole.Name);

                            var usuario = await Mediator.Send(new GetUsuarioByIdQuery { Id = user.Id });


                            var commandUsu = new UpdateUsuarioCommand
                            {
                                NomUsuario = user.Nome,
                                NumTelefone = user.Telefone,
                                CodEmpresa = usuario.CodEmpresa,
                                CodUnidadeInfraestrutura = usuario.CodUnidadeInfraestrutura,
                                CodPerfil = userRole.Id,
                                NomPerfil = userRole.Name,
                            };
                            
                            var resultUsu = await Mediator.Send(commandUsu);
                    }
                }

                var result = await _roleManager.DeleteAsync(obj);

                return result.Succeeded;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        [HttpGet("GetPerfilAll")]
        public async Task<List<PerfilDto>> GetPerfilAll()
        {
            try
            {
                var list = _db.Roles.Select(s => s).ToList().Select(item => new PerfilDto { NomPerfil = item.Name, CodPerfil = item.Id }).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
        [HttpGet("GetModuloAll")]
        public async Task<List<ModuloDto>> GetModuloAll()
        {
            try
            {
                var result = await Mediator.Send(new GetModuloAllQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
