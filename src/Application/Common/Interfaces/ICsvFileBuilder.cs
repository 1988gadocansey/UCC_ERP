using UCC_ERP.Application.TodoLists.Queries.ExportTodos;

namespace UCC_ERP.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
