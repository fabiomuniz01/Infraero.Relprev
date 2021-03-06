﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Local.Commands.CreateLocal;
using Infraero.Relprev.Application.Local.Commands.DeleteLocal;
using Infraero.Relprev.Application.Local.Commands.UpdateLocal;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
using Microsoft.AspNetCore.Mvc;

namespace Infraero.Relprev.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class LocalController : ApiController
    {
        [HttpPost("CreateLocal")]
        public async Task<ActionResult<long>> CreateLocal(CreateLocalCommand command)
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

        [HttpGet("GetGridLocal")]
        public async Task<GridLocal> GetGridLocal()
        {
            try
            {
                var result = await Mediator.Send(new GetGridLocalsQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        [HttpGet("GetLocalById/{id}")]
        public async Task<LocalDto> GetLocalById(int id)
        {
            try
            {
                var result = await Mediator.Send(new GetLocalByIdQuery {Id = id});
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }


        [HttpPost("UpdateLocal")]
        public async Task<ActionResult<bool>> UpdateLocal(UpdateLocalCommand command)
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

        [HttpPost("DeleteLocal")]
        public async Task<ActionResult<bool>> DeleteLocal(DeleteLocalCommand command)
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

        [HttpGet("GetLocalAll")]
        public async Task<List<LocalDto>> GetLocalAll()
        {
            try
            {
                var result = await Mediator.Send(new GetLocalAllQuery());
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        //[HttpGet("GetLocalByIdUnidade")]
        //public async Task<List<LocalDto>> GetLocalByIdUnidade(int id)
        //{
        //    try
        //    {
        //        var result = await Mediator.Send(new GetLocalByIdUnidadeQuery(id = id));
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