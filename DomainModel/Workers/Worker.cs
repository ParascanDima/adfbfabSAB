using System;
using DomainModel.Time;

namespace DomainModel.Workers
{
    internal class Worker : Human, IWorker
    {
        private readonly string _position;

        public Worker(string position = null, string firstName = null, string lastName = null, int? _age = null,
            string _gender = null) : base(firstName, lastName, _age, _gender)
        {
            _position = position;
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position: {_position}");
        }

        public Information Info() => info;
        

        public string GetPosition() => _position;

        public void EndTaskMessage(object sender, FinishTaskEventArgs e)
        {
            var c = new string('\"', 4);
            if (GetLastName() != e._lastName && GetFirstName() != e._name)
            {
                Console.WriteLine($"{GetFirstName()} {GetLastName()} get the message: ");
                Console.WriteLine($" {c,15} {e._name} {e._lastName} ended the \"{e._task}\" at {e._time} {c,-15}\n");
            }
        }

        public void Unregister(EndTask ET) => ET.TaskIsFinishedEvent -= EndTaskMessage;

    }
}