using System.Globalization;
using UCC_ERP.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace UCC_ERP.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
