using UCC_ERP.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using UCC_ERP.Application.TodoLists.Commands.UpdateTodoList;

public class UpdateCollegeCommandValidator : AbstractValidator<UpdateCollegeCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateCollegeCommandValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(v => v.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(200).WithMessage("Name must not exceed 200 characters.")
            .MustAsync(BeUniqueName).WithMessage("The specified College already exists.");
    }

    private async Task<bool> BeUniqueName(UpdateCollegeCommand model, string name, CancellationToken cancellationToken)
    {
        return await _context.Colleges
            .Where(l => l.Id != model.Id)
            .AllAsync(l => l.Name != name, cancellationToken);
    }
}
