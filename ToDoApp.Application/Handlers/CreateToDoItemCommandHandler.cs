using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Commands;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Services;

namespace ToDoApp.Application.Handlers;

public class CreateToDoItemCommandHandler : IRequestHandler<CreateToDoItermCommand, int>
{
    private readonly IToDoRepository _toDoRepository;
    public CreateToDoItemCommandHandler(IToDoRepository toDoRepository )
    {
        _toDoRepository = toDoRepository;
    }

    public Task<int> Handle(CreateToDoItermCommand request, CancellationToken cancellationToken)
    {
        var item = new ToDoItem { Description = request.Description };

        return _toDoRepository.CreateAsync(item);
    }
}

