using FluentValidation;
using UCC_ERP.Application.TodoItems.Queries.GetTodoItemsWithPagination;

namespace UCC_ERP.Application.Colleges.Queries;

public class GetCollegeQueryWithPaginationValidator: AbstractValidator<GetCollegeQueryWithPagination>
{
    public GetCollegeQueryWithPaginationValidator()
    {

        RuleFor(x => x.PageNumber)
            .GreaterThanOrEqualTo(1).WithMessage("PageNumber at least greater than or equal to 1.");

        RuleFor(x => x.PageSize)
            .GreaterThanOrEqualTo(1).WithMessage("PageSize at least greater than or equal to 1.");
    }
}