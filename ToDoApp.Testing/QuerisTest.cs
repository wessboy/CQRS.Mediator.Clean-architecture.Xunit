using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Handlers;
using ToDoApp.Application.Queries;
using ToDoApp.Domain.Services;

namespace ToDoApp.Testing;

    public class QuerisTest
    {
        [Fact]
        public async Task GivenToDoItemQueryHandler_WhenHandleCalled_ThenReturnToDoItems()
    {
        //Arrange
        var mockRepository = new Mock<IToDoRepository>();
        mockRepository.Setup(x => x.GetAllAsync())
            .ReturnsAsync
            ([
                new() {Description = "Item 1"},
                new() { Description = "Item 2" }
             ]);

        var toDoItemQueryHandler = new ToDoItemQueryHandler(mockRepository.Object);
        var toDoItemQuery = new ToDoItemQuery();

        //Act 
        var result = await toDoItemQueryHandler.Handle(toDoItemQuery,CancellationToken.None);

        //Assert
        Assert.Equal(2, result.Count);
        Assert.Equal("Item 1", result[0].Description);
        Assert.Equal("Item 2", result[^1].Description);

    }
    }

