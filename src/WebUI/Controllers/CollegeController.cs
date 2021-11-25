using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UCC_ERP.Application.Colleges.Commands.CreateCollege;
using UCC_ERP.Application.Colleges.Queries;
using UCC_ERP.Application.Common.Models;
using UCC_ERP.Application.Students.Commands.CreateStudent;
using UCC_ERP.Application.TodoLists.Queries.GetTodos;

namespace UCC_ERP.WebUI.Controllers;
[Authorize]
public class CollegeController: ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<PaginatedList<CollegeDto>>> GetCollegeWithPagination([FromQuery] GetCollegeQueryWithPagination query)
    {
        return await Mediator.Send(query);
    }
    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateCollegeCommand command)
    {
        return await Mediator.Send(command);
    }
}