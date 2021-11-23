using MediatR;
using UCC_ERP.Application.Common.Interfaces;
using UCC_ERP.Domain.Entities;
using UCC_ERP.Domain.Events;

namespace UCC_ERP.Application.Colleges.Commands.CreateCollege;

public class CreateCollegeCommand : IRequest<int>
{
    public string Name { get; set; }

    public Guid Uuid { get; set; }
}

public class CreateCollegeCommandHandler : IRequestHandler<CreateCollegeCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateCollegeCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateCollegeCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine("request name is" + request.Uuid);
        College entity = new College { Name = request.Name, Uuid = request.Uuid };

        entity.DomainEvents.Add(new CollegeCreatedEvent(entity));

        _context.Colleges.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}