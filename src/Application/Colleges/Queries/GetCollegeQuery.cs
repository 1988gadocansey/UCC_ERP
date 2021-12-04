using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UCC_ERP.Application.Common.Interfaces;
using UCC_ERP.Application.TodoLists.Queries.GetTodos;
using UCC_ERP.Domain.Enums;

namespace UCC_ERP.Application.Colleges.Queries;
public class GetCollegeQuery : IRequest<CollegeVm>
{
}
public class GetCollegeQueryHandler : IRequestHandler<GetCollegeQuery, CollegeVm>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public  GetCollegeQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<CollegeVm> Handle(GetCollegeQuery request, CancellationToken cancellationToken)
    {
        return new CollegeVm
        {
            

            Lists = await _context.Colleges
                .AsNoTracking()
                .ProjectTo<CollegeDto>(_mapper.ConfigurationProvider)
                .OrderBy(t => t.Name)
                .ToListAsync(cancellationToken)
        };
    }
}