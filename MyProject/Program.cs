using System;
using System.IO;
using System.Linq;
using System.Text;
using DomainModel.Task;
using DomainModel.Time;
using DomainModel.Workers;
using Infrastructure;
using VurtualDataBase.Interface;

namespace MyProject
{
    internal class Program
    {
        static Program()
        {
            ServiceLocator.RegisterAll();
        }

        private static void Main(string[] args)
        {
            var endOfTask = new EndTask();

            var workerDataBase = ServiceLocator.Resolve<IWorkerData>();


            var workerData = workerDataBase.GetDataBase<Worker>();
            var admin = workerDataBase.GetDataBase<Administrator>();

            foreach (var p in admin)
            {
                p.ShowInfo();
            }

            Console.WriteLine("\n");

            var taskList = workerData.Select(t => new Task(t)).ToList();

            var end = new TimeST(14, 16);

            const string addr = @"D:\Files&StreamExampleForProject";

            Directory.CreateDirectory(addr);

            if (File.Exists($@"{addr}\ReadData.txt"))
            {
                File.Delete($@"{addr}\ReadData.txt");
            }

            var f = new FileInfo($@"{addr}\ReadData.txt");
            using (TextWriter file = new StreamWriter(f.OpenWrite(), Encoding.UTF8))
            {
                Console.WriteLine("Enter the tasks: ");

                for (var i = 0; i < taskList.Count; i++)
                {
                    file.WriteLine($"{Console.ReadLine()}");
                }
            }

            Console.WriteLine("\n");


            using (TextReader file = new StreamReader(f.OpenRead(), Encoding.UTF8))
            {
                foreach (var n in taskList)
                {
                    n.TaskName = file.ReadLine();
                }
            }


            taskList[0].SetEndTaskTime(end, endOfTask);

            Console.ReadKey();
        }
    }
}