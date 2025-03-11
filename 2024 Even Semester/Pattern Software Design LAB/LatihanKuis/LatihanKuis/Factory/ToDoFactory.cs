using LatihanKuis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LatihanKuis.Factory
{
    public class ToDoFactory
    {
        public ToDo CreateToDo(string toDoId, string name, int reward, string category, string userId)
        {
            return new ToDo()
            {
                TodoId = toDoId,
                Name = name,
                Reward = reward,
                Category = category,
                UserId = userId
            };
        }
    }
}