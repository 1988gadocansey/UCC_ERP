using FluentValidation;
using Microsoft.EntityFrameworkCore;
using UCC_ERP.Application.Colleges.Commands.CreateCollege;
using UCC_ERP.Application.Common.Interfaces;

namespace UCC_ERP.Application.Students.Commands.CreateStudent;

public class CreateCollegeCommandValidator : AbstractValidator<CreateCollegeCommand>
{
    private readonly IApplicationDbContext _context;
    public CreateCollegeCommandValidator(IApplicationDbContext context)
    {
        _context = context;

        RuleFor(v => v.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(200).WithMessage("Name must not exceed 200 characters.")
            .MustAsync(BeUniqueName).WithMessage("The specified Name already exists.");
    }

    private async Task<bool> BeUniqueName(string name, CancellationToken cancellationToken)
    {
        return await _context.Colleges
            .AllAsync(l => l.Name != name, cancellationToken);
    }
}