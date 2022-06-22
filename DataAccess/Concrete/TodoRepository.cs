using Microsoft.EntityFrameworkCore;
using System;
//using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Entity.Concrete;


namespace DataAccess.Concrete
{
    public interface ITodoRepository
    {
        TodoModel Add(string todo);
        void ChangeChecked(int id);
        void Delete(int id);
        TodoModel GetById(int id);
        IEnumerable<TodoModel> GetAll();
        //List<TodoModel> GetAll();
    }

    public class TodoRepository : ITodoRepository
    {
        Context context = new Context();

        public TodoModel Add(string todo)
        {
            TodoModel model = new TodoModel() { todo = todo, isDone = false };
            context.Todos.Add(model);
            context.SaveChanges();
            return model;
        }

        public void Delete(int id)
        {
            TodoModel model = context.Todos.Find(id);
            context.Todos.Remove(model);
            context.SaveChanges();
        }

        public IEnumerable<TodoModel> GetAll()
        {
            return context.Todos.ToList();
        }

        public TodoModel GetById(int id)
        {
            TodoModel model = context.Todos.Find(id);
            return model;
        }

        public void ChangeChecked(int id)
        {
            TodoModel model = context.Todos.Find(id);
            if (model.isDone)
                model.isDone = false;
            else
                model.isDone = true;
            context.SaveChanges();
        }
    }
}
