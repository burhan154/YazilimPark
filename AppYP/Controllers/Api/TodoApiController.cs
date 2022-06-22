using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppYP.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoApiController : ControllerBase
    {
        private TodoRepository todoRepository = new TodoRepository();

        [HttpGet]
        public IEnumerable<TodoModel> GetTodos()
        {
            return todoRepository.GetAll();
        }
        [HttpGet("{id}")]
        public TodoModel GetTodo(int id)
        {
            return todoRepository.GetById(id);
        }
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            todoRepository.Delete(id);
            return true;
        }
        [HttpPost("{todo}")]
        public TodoModel Add(string todo)
        {
            return todoRepository.Add(todo);
        }
        [HttpPut("{id}")]
        public bool Change(int id)
        {
            todoRepository.ChangeChecked(id);
            return true; 
        }
    }
}
