using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos;
using Infraero.Relprev.Application.Relato.Commands.CreateRelato;
using Infraero.Relprev.Application.Relato.Commands.CancelRelato;
using Infraero.Relprev.Application.Relato.Commands.UpdateRelato;
using Infraero.Relprev.Application.Relato.Commands.ClassificarRelato;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;
using Infraero.Relprev.CrossCutting.Enumerators;
using Infraero.Relprev.CrossCutting.Extensions;
using Infraero.Relprev.CrossCutting.Helpers;
using Microsoft.AspNetCore.Mvc;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using EnumSituacaoAtribuicao = Infraero.Relprev.CrossCutting.Enumerators.EnumSituacaoAtribuicao;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class RelatoController : ApiController
    {
        private readonly ApplicationDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RelatoController(ApplicationDbContext db, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
        }
        [HttpPost("ClassificarRelato")]
        public async Task<ActionResult<bool>> ClassificarRelato(ClassificarRelatoCommand command)
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

        [HttpPost("CreateRelato")]
        public async Task<ActionResult<long>> CreateRelato(CreateRelatoCommand command)
        {
            try
            {
                command.NumTelefoneRelator = Criptografia.Encriptar(command.NumTelefoneRelator);

                var unidade = await Mediator.Send(new GetUnidadeInfraEstruturaByIdQuery { CodUnidadeInfraestrutura = (int)command.CodUnidadeInfraestrutura });

                command.Sigla = unidade.Sigla;

                var sgsoRole = await _roleManager.FindByNameAsync(UserRoles.GestorSgsoSite);

                command.CodPerfilSgso = sgsoRole.Id;

                command.CodSituacaoAtribuicao = (int) EnumSituacaoAtribuicao.OcorrenciaAtribuída;

                var result = await Mediator.Send(command);

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        [HttpGet("GetGridRelato")]
        public async Task<GridRelato> GetGridRelato()
        {
            try
            {
                var result = await Mediator.Send(new GetRelatoAllQuery());
                return new GridRelato
                {
                    aaData = result.Select(s => new RelatoDto
                    {
                        CodRelato = s.CodRelato,
                        NumRelato = s.NumRelato,
                        StatusRelato = ((EnumStatusRelato)s.FlgStatusRelato).GetDescription(),
                        DatOcorrencia = s.DatOcorrencia,
                        HorOcorrencia = s.HorOcorrencia,
                        CodUnidadeInfraestrutura = s.CodUnidadeInfraestrutura,

                    })
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("GetRelatoAll")]
        public async Task<List<RelatoDto>> GetRelatoAll()
        {
            try
            {
                var result = await Mediator.Send(new GetRelatoAllQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetRelatoById/{id}")]
        public async Task<RelatoDto> GetRelatoById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetRelatoByIdQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetRelatoByNumrelato/{id}")]
        public async Task<RelatoDto> GetRelatoByNumrelato(string id)
        {
            try
            {
                var result = await Mediator.Send(new GetRelatoByNumRelatoQuery { numRelato = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetRelatoArquivosById/{id}")]
        public async Task<RelatoArquivoDto> GetRelatoArquivosById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetRelatoArquivoByIdQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetRelatoArquivoByIdRelato/{id}")]
        public async Task<List<RelatoArquivoDto>> GetRelatoArquivoByIdRelato(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetRelatoArquivoByIdRelatoQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpPost("CancelRelato")]
        public async Task<ActionResult<long>> CancelRelato(CancelRelatoCommand command)
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

        [HttpPost("UpdateRelato")]
        public async Task<ActionResult<bool>> UpdateRelato(ClassificarRelatoCommand command)
        {
            try
            {
                var sgsoRole = await _roleManager.FindByNameAsync(UserRoles.GestorSgsoSite);

                command.CodPerfilSgso = sgsoRole.Id;

                command.CodSituacaoAtribuicao = (int)EnumSituacaoAtribuicao.OcorrenciaAtribuída;

                var result = await Mediator.Send(command);

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetAtribuicaoByCodRelato/{id}")]
        public async Task<List<AtribuicaoRelatoDto>> GetAtribuicaoByCodRelato(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetAtribuicaoRelatoByIdRelatoQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        //[HttpPost("DeleteRelato")]
        //public async Task<ActionResult<bool>> DeleteRelato(DeleteRelatoCommand command)
        //{
        //    try
        //    {
        //        var result = await Mediator.Send(command);
        //        return result;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //}
    }
}