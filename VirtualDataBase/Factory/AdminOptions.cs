using DomainModel.Time;
using DomainModel.Workers;

namespace VirtualDataBase.Factory
{
    internal class AdminOptions : IOptions
    {
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

        public virtual IOptions WithPosition(string v)
        {
            return this;
        }

        public IWorker Apply(EndTask ET)
        {
            return new Administrator(Name, LastName, Age, Gender, ET);
        }
    }
}