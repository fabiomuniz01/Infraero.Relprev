using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Perfil.Commands.CreatePerfil;
using Infraero.Relprev.Application.Perfil.Commands.DeletePerfil;
using Infraero.Relprev.Application.Perfil.Commands.UpdatePerfil;
using Infraero.Relprev.Application.Perfil.Queries.GetPerfils;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.Api.Controllers
{
    [Route("api/[controller]")]
    public class PerfilController : ApiController
    {
        private readonly ApplicationDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<WebProfileUser> _userManager;
        private readonly SignInManager<WebProfileUser> _signInManager;

        public PerfilController(ApplicationDbContext db, RoleManager<IdentityRole> roleManager, UserManager<WebProfileUser> userManager, SignInManager<WebProfileUser> signInManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("CreatePerfil")]
        public async Task<ActionResult<long>> CreatePerfil(CreatePerfilCommand command)
        {
            try
            {
                //var user = await _userManager.FindByEmailAsync(command.UserIdentity);

                await _roleManager.CreateAsync(new IdentityRole { Name = command.NomPerfil });

                // set this registering user as admin/everything
                //await _userManager.AddToRolesAsync(user,
                //    new[] { UserRoles.Administrator });

                //await _userManager.AddToRoleAsync(user, UserRoles.Registered);

                return 1;
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
                var result = await Mediator.Send(new GetGridPerfilsQuery());

                try
                {
                    var responseModel = _db.Roles;

                    var list = responseModel.Select(s => s.Name).ToList().Select(item => new PerfilDto {NomPerfil = item, DscPerfil = item}).ToList();
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





                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetPerfilById/{id}")]
        public async Task<PerfilDto> GetPerfilById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetPerfilByIdQuery { Id = id });
                return result;
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
                var result = await Mediator.Send(command);

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
                var result = await Mediator.Send(command);
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
