using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Infraero.Relprev.Application.AtribuicaoRelato.Commands.CreateResponsavelTecnico;
using Infraero.Relprev.Application.AtribuicaoRelato.Commands.CreateAtribuicaoRelato;
using Infraero.Relprev.Application.AtribuicaoRelato.Commands.UpdateAtribuicaoRelato;
using Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos;

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
    public class AtribuicaoRelatoController : ApiController
    {
        private readonly ApplicationDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AtribuicaoRelatoController(ApplicationDbContext db, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
        }
        [HttpPost("AtribuirResponsavelTecnico")]
        public async Task<ActionResult<long>> AtribuirResponsavelTecnico(CreateResponsavelTecnicoCommand command)
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

        [HttpPost("CreateAtribuicaoRelato")]
        public async Task<ActionResult<long>> CreateRelato(CreateAtribuicaoRelatoCommand command)
        {
            try
            {

                var unidade = await Mediator.Send(new GetUnidadeInfraEstruturaByIdQuery { CodUnidadeInfraestrutura = (int)command.CodUnidadeInfraestrutura });

                var result = await Mediator.Send(command);

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


        [HttpGet("GetAtribuicaoByIdRelato/{id}")]
        public async Task<List<AtribuicaoRelatoDto>> GetAtribuicaoByIdRelato(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetAtribuicaoRelatoByIdRelatoQuery { Id = id });
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpGet("GetAtribuicaoRelatoAll")]
        public async Task<List<AtribuicaoRelatoDto>> GetAtribuicaoRelatoAll()
        {
            try
            {
                var result = await Mediator.Send(new GetAtribuicaoRelatoAllQuery());
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