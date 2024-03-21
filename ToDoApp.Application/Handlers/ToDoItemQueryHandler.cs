using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Queries;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Services;

namespace ToDoApp.Application.Handlers;

public class ToDoItemQueryHandler : IRequestHandler<ToDoItemQuery, List<ToDoItem>>
{
    private readonly IToDoRepository _toDoRepository;
    public ToDoItemQueryHandler(IToDoRepository toDoRepository)
    {
        _toDoRepository = toDoRepository;
    }
    public Task<List<ToDoItem>> Handle(ToDoItemQuery request, CancellationToken cancellationToken)
    {
        return _toDoRepository.GetAllAsync();
    }
}

