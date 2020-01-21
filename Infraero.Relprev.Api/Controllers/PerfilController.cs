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
        public async Task<ActionResult<bool>> CreatePerfil(CreatePerfilCommand command)
        {
            try
            {
                var result =  await _roleManager.CreateAsync(new IdentityRole { Name = command.NomPerfil }); 

                return result.Succeeded;
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
                var result = _db.Roles.Where(x => x.Id == id).Select(item => new PerfilDto { NomPerfil = item.Name, CodPerfil = item.Id }).FirstOrDefault();

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
                var obj = _db.Roles.Where(x => x.Id == command.CodPerfil).FirstOrDefault();

                obj.Name = command.NomPerfil;
                obj.NormalizedName = command.NomPerfil.ToUpper();
                
                var result = await _roleManager.UpdateAsync(obj);

                return result.Succeeded;
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

    }
}
