using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UCC_ERP.Application.Common.Interfaces;
using UCC_ERP.Application.Common.Mappings;
using UCC_ERP.Application.Common.Models;
using UCC_ERP.Application.TodoItems.Queries.GetTodoItemsWithPagination;

namespace UCC_ERP.Application.Colleges.Queries;

public class GetCollegeQueryWithPagination: IRequest<PaginatedList<CollegeDto>>
{
    public int Id { get; set; }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}


public class GetCollegeQueryWithPaginationQueryHandler : IRequestHandler<GetCollegeQueryWithPagination, PaginatedList<CollegeDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;
    
    public GetCollegeQueryWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<PaginatedList<CollegeDto>> Handle(GetCollegeQueryWithPagination request, CancellationToken cancellationToken)
    {
        return await _context.Colleges
            //.Where(x => x.Id == request.Id)
            .OrderBy(x => x.Name)
            .ProjectTo<CollegeDto>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
     
}