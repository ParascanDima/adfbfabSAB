using System;
using DomainModel.Time;

namespace DomainModel.Workers
{
    internal class Administrator : Human, IWorker
    {
        private const string Position = "Administrator";

        public Administrator(string firstName, string lastName, int? _age, string _gender, EndTask ET)
            : base(firstName, lastName, _age, _gender)
        {
            ET.TaskIsFinishedEvent += EndTaskMessage;
        }

        public void EndTaskMessage(object sender, FinishTaskEventArgs e)
        {
            var c = new string('\"', 4);
            if (lastName != e._lastName && firstName != e._name)
            {
                Console.WriteLine($"{firstName} {lastName} get the message: ");
                Console.WriteLine($" {c,15} {e._name} {e._lastName} ended the \"{e._task}\" at {e._time} {c,-15}\n");
            }
        }

        public Information Info() => info;

        public string GetPosition()
        {
            return Position;
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"He is mazafaka {Position}");
        }

        public void Unregister(EndTask ET) => ET.TaskIsFinishedEvent -= EndTaskMessage;
    }
}