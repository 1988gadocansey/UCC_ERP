using System.Globalization;
using UCC_ERP.Application.Common.Interfaces;
using UCC_ERP.Application.TodoLists.Queries.ExportTodos;
using UCC_ERP.Infrastructure.Files.Maps;
using CsvHelper;

namespace UCC_ERP.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
