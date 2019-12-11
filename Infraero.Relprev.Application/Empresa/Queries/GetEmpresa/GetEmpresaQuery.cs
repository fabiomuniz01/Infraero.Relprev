//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using AutoMapper;
//using AutoMapper.QueryableExtensions;
//using Infraero.Relprev.Application.Common.Interfaces;
//using MediatR;
//using Microsoft.EntityFrameworkCore;

//namespace Infraero.Relprev.Application.Empresa.Queries.GetEmpresa
//{
//    public class GetEmpresaQuery : IRequest<EmpresaVm>
//    {
//        public class GetEmpresaQueryHandler : IRequestHandler<GetEmpresaQuery, EmpresaVm>
//        {
//            private readonly IApplicationDbContext _context;
//            private readonly IMapper _mapper;

//            public GetEmpresaQueryHandler(IApplicationDbContext context, IMapper mapper)
//            {
//                _context = context;
//                _mapper = mapper;
//            }

//            public async Task<EmpresaVm> Handle(GetEmpresaQuery request, CancellationToken cancellationToken)
//            {
//                //var vm = new EmpresaVm();



//                //vm.Lists = await _context.TodoLists
//                //    .ProjectTo<TodoListDto>(_mapper.ConfigurationProvider)
//                //    .OrderBy(t => t.Title)
//                //    .ToListAsync(cancellationToken);

//                //return vm;

//                var vm = await _context.Empresa
//                    .Where(t => t.Id == request.Id)
//                    .ProjectTo<EmpresaVm>(_mapper.ConfigurationProvider)
//                    .FirstOrDefaultAsync(cancellationToken);

//                return vm;
//            }
//        }
//    }
//}
