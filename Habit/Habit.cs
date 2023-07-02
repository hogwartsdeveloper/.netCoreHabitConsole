using System;

namespace Habit
{
    class Habit
    {
        public readonly string Name;
        public bool IsDone => this._isDone;
        private bool _isDone;
        private int _howMany;
        private int Duration { get; }

        public Habit(string name,int duration)
        {
            this.Name = name;
            this.Duration = duration;
            this._howMany = 0;
            this._isDone = false;
        }

        public void Done(int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException("The number of completed count cannot be less than one");
            }

            this._howMany += count;
            this._isDone = this.CheckIsDone();
        }

        private bool CheckIsDone()
        {
            return this._howMany >= Duration;
        }
    }
}