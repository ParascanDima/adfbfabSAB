using DomainModel.Time;
using DomainModel.Workers;
using VirtualDataBase.Factory;

namespace VirtualDataBase.Demo.Factory
{
    internal class WorkerOptions : IOptions
    {
        private string _position;
        protected string Name { set; get; }
        protected string LastName { set; get; }
        protected string Gender { set; get; }
        protected int? Age { get; set; }

        public IOptions WithName(string name)
        {
            Name = name;
            return this;
        }

        public IOptions WithLastName(string lastName)
        {
            LastName = lastName;
            return this;
        }

        public IOptions WithAge(int? Age)
        {
            this.Age = Age;
            return this;
        }

        public IOptions WithGender(string gender)
        {
            Gender = gender;
            return this;
        }

        public IOptions WithPosition(string position)
        {
            _position = position;
            return this;
        }

        public IWorker Apply(EndTask ET)
        {
            return new Worker(_position, Name, LastName, Age, Gender);
        }
    }
}