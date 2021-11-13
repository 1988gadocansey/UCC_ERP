using UCC_ERP.Application.Common.Exceptions;
using UCC_ERP.Application.TodoLists.Commands.CreateTodoList;
using UCC_ERP.Application.TodoLists.Commands.DeleteTodoList;
using UCC_ERP.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace UCC_ERP.Application.IntegrationTests.TodoLists.Commands;

using static Testing;

public class DeleteTodoListTests : TestBase
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand { Id = 99 };
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand
        {
            Id = listId
        });

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}
