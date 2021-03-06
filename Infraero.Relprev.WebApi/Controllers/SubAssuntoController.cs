﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.SubAssunto.Commands.CreateSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Commands.DeleteSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Commands.UpdateSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class SubAssuntoController : ApiController
    {
        [HttpPost("CreateSubAssunto")]
        public async Task<ActionResult<long>> CreateSubAssunto(CreateSubAssuntoCommand command)
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

        [HttpGet("GetGridSubAssunto")]
        public async Task<GridSubAssunto> GetGridSubAssunto()
        {
            try
            {
                var result = await Mediator.Send(new GetGridSubAssuntosQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        [HttpGet("GetSubAssuntoById/{id}")]
        public async Task<SubAssuntoDto> GetSubAssuntoById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetSubAssuntoByIdQuery {Id = id});
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        [HttpGet("GetSubAssuntoAll")]
        public async Task<List<SubAssuntoDto>> GetSubAssuntoAll()
        {
            try
            {
                var result = await Mediator.Send(new GetSubAssuntoAllQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpPost("UpdateSubAssunto")]
        public async Task<ActionResult<bool>> UpdateSubAssunto(UpdateSubAssuntoCommand command)
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

        [HttpPost("DeleteSubAssunto")]
        public async Task<ActionResult<bool>> DeleteSubAssunto(DeleteSubAssuntoCommand command)
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