using Moq;
using ToDoApp.Application.Commands;
using ToDoApp.Application.Handlers;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Services;

namespace ToDoApp.Testing;

    public class CommandsTest
    {
        [Fact]
        public void GivenCreateToDoItemCommandHandler_WhenHandleCalled_ThenCreateNewToDoItem()
        {

            //Arrange
            var toDoRepositroyMock = new Mock<IToDoRepository>();
            toDoRepositroyMock.Setup(x => x.CreateAsync(It.IsAny<ToDoItem>())).ReturnsAsync(1);

            var createToDoItemCommandHandler = new CreateToDoItemCommandHandler(toDoRepositroyMock.Object);

            var createToDoCommand = new CreateToDoItermCommand { Description = "test Description" };

            //Act 

            var result = createToDoItemCommandHandler.Handle(createToDoCommand, CancellationToken.None).Result;

            //Assert
            Assert.Equal(1, result);


        }
    }
