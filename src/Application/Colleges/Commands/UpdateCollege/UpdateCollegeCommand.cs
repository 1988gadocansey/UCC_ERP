using UCC_ERP.Application.Common.Exceptions;
using UCC_ERP.Application.Common.Interfaces;
using UCC_ERP.Domain.Entities;
using MediatR;

namespace UCC_ERP.Application.TodoLists.Commands.UpdateTodoList;

public class UpdateCollegeCommand : IRequest
{
    public int Id { get; set; }

    public string? Name { get; set; }
}

public class UpdateCollegeCommandHandler : IRequestHandler<UpdateCollegeCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateCollegeCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UpdateCollegeCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Colleges
            .FindAsync(new object[] { request.Id }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(College), request.Id);
        }
        Console.WriteLine("update called");
        entity.Name = request.Name;

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
