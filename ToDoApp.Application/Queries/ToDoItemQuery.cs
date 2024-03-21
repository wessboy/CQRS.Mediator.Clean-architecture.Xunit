using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Queries;

     public class ToDoItemQuery : IRequest<List<ToDoItem>>
    {
    }

