using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Habit
{
    class Client
    {
        public string Name;
        private List<Habit> _habits = new List<Habit>();

        public Client(string name)
        {
            this.Name = name;
        }

        public void CreateHabit(string name, int duration)
        {
            var findIndex = this._habits.FindIndex(item => item.Name == name);
            if (findIndex != -1)
            {
                throw new ArgumentException("A habit with that name already exists");
            }
            
            this._habits.Add(new Habit(name, duration));
        }

        public void Done(string name, int count)
        {
            var findIndex = this._habits.FindIndex(item => item.Name == name);
            if (findIndex == -1)
            {
                throw new ArgumentException("A habit with that name not exists");
            }

            var habit = this._habits[findIndex];
            habit.Done(count);
            if (habit.IsDone)
            {
                Console.WriteLine("Yes habit consolidation!");
            }
        }
    }
    
}