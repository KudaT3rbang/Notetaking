using LatihanKuis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LatihanKuis.Repositories
{
    public class ToDoRepository
    {
        Database1Entities db = new Database1Entities();

        public List<ToDo> GetToDoListByUserId(string userId)
        {
            return db.ToDoes.Where(td => td.UserId == userId).ToList();
        }

        public void InsertToDo(ToDo toDo)
        {
            db.ToDoes.Add(toDo);
            db.SaveChanges();
        }

        public void DeleteToDo(ToDo toDo)
        {
            db.ToDoes.Remove(toDo);
            db.SaveChanges();
        }

        public ToDo GetToDoById(string toDoId)
        {
            return db.ToDoes.Find(toDoId);
        }
    }
}