using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Dapper;
using Infraero.Relprev.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas
{
    public class GetDependenciaAllQuery : IRequest<List<UnidadeInfraEstruturaDto.Dependencia>>
    {
        public class GetDependenciaAllQueryHandler : IRequestHandler<GetDependenciaAllQuery, List<UnidadeInfraEstruturaDto.Dependencia>>
        {
            private readonly IConfiguration _configuration;
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;


            public GetDependenciaAllQueryHandler(IApplicationDbContext context, IMapper mapper, IConfiguration configuration)
            {
                _context = context;
                _mapper = mapper;
                _configuration = configuration;
            }

            public IDbConnection GetConnection()
            {
                var connectionString = _configuration.GetSection("ConnectionStrings").GetSection("OracleConnection").Value;
                var conn = new OracleConnection(connectionString);
                return conn;
            }

            public async Task<List<UnidadeInfraEstruturaDto.Dependencia>> Handle(GetDependenciaAllQuery request, CancellationToken cancellationToken)
            {
                object result = null;

                try
                {
                    var conn = this.GetConnection();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    if (conn.State == ConnectionState.Open)
                    {
                        var query = @"SELECT dep_codigo, dep_nome, dep_sigla, dep_sigla || ' - ' || dep_nome as dep_sigla_nome, dep_endereco_logradouro, dep_endereco_complemento, dep_numero_logradouro,
                                    dep_endereco_bairro, dep_endereco_municipio, dep_ufe_sigla, dep_endereco_cep, dep_numero_telefone_1
                                    FROM DEPENDENCIAS where dep_tipo = 3 order by dep_nome";

                        result = SqlMapper.Query<UnidadeInfraEstruturaDto.Dependencia>(conn, query, commandType: CommandType.Text);

                    }


                    return result as List<UnidadeInfraEstruturaDto.Dependencia>;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                
            }
        }

    }
}
