using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Domain.Services;

     public interface IToDoRepository
    {
       Task<List<ToDoItem>> GetAllAsync();
       Task<int> CreateAsync(ToDoItem item);
    }

