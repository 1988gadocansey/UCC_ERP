using UCC_ERP.Application.Common.Mappings;
using UCC_ERP.Domain.Entities;

namespace UCC_ERP.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
