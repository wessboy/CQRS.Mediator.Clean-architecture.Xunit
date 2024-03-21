using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Application.Commands;

     public class CreateToDoItermCommand : IRequest<int>
    {
        public required string Description { get; set; }    
    }

