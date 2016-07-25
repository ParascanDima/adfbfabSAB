using System;

namespace DomainModel.Workers
{
    abstract class Human
    {
        protected string firstName;
        protected string lastName;
        protected Information info { get; set; }


        public Human(string firstName, string lastName, int? _age, string _gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            info = new Information(_age, _gender);
        }

        public void ShowInfo()
        {
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            if (info.GetAge() == null)
            {
                Console.WriteLine("Age: Unknow information");
            }
            else Console.WriteLine("Age: " + info.GetAge());
            Console.WriteLine("Gender: " + info.GetGender());
        }


        public string GetFirstName() => firstName;

        public string GetLastName() => lastName;
    }
}
