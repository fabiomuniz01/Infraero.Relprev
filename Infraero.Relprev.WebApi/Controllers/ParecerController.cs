using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Infraero.Relprev.Application.Parecer.Commands.CreateParecer;
using Infraero.Relprev.Application.Parecer.Commands.CompleteParecer;
using Infraero.Relprev.Application.Parecer.Commands.UpdateParecer;

using Infraero.Relprev.Application.Parecer.Queries.GetParecer;
using Infraero.Relprev.Application.ParecerArquivo.Queries.GetParecerArquivos;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Extensions;
using Infraero.Relprev.CrossCutting.Helpers;
using Microsoft.AspNetCore.Mvc;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using EnumSituacaoAtribuicao = Infraero.Relprev.CrossCutting.Enumerators.EnumSituacaoAtribuicao;
using Infraero.Relprev.Application.Parecer.Commands.AvaluateParecer;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ParecerController : ApiController
    {
        private readonly ApplicationDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ParecerController(ApplicationDbContext db, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
        }

      
        [HttpPost("CreateParecer")]
        public async Task<ActionResult<long>> CreateParecer(CreateParecerCommand command)
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

        [HttpPost("AvaluateParecer")]
        public async Task<ActionResult<long>> AvaluateParecer(AvaluateParecerCommand command)
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

        [HttpGet("GetGridParecer")]
        public async Task<GridParecer> GetGridParecer()
        {
            try
            {
                var result = await Mediator.Send(new GetParecerAllQuery());
                return new GridParecer
                {
                    aaData = result.Select(s => new ParecerDto
                    {
                        CodParecer = s.CodParecer,
                        StatusParecer = ((EnumStatusParecer)s.FlgStatusParecer).GetDescription(),
                        FlgStatusParecer = s.FlgStatusParecer,
                        DscPasrecer =s.DscPasrecer,
                        DscComplementoParecer = s.DscComplementoParecer
                    })
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("GetParecerAll")]
        public async Task<List<ParecerDto>> GetParecerAll()
        {
            try
            {
                var result = await Mediator.Send(new GetParecerAllQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetParecerById/{id}")]
        public async Task<ParecerDto> GetParecerById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetParecerByIdQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetParecerByStatus/{id}")]
        public async Task<List<ParecerDto>> GetParecerByStatus(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetParecerByStatusQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetParecerByIdRelato/{id}")]
        public async Task<List<ParecerDto>> GetParecerByIdRelato(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetParecerByIdRelatoQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetParecerArquivosById/{id}")]
        public async Task<ParecerArquivoDto> GetParecerArquivosById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetParecerArquivoByIdQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetParecerArquivoByIdParecer/{id}")]
        public async Task<List<ParecerArquivoDto>> GetParecerArquivoByIdParecer(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetParecerArquivoByIdParecerQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpPost("CompleteParecer")]
        public async Task<ActionResult<long>> CancelParecer(CompleteParecerCommand command)
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

        [HttpPost("UpdateParecer")]
        public async Task<ActionResult<bool>> UpdateParecer(UpdateParecerCommand command)
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