using System.Collections.Generic;
using DomainModel.Workers;
using VirtualDataBase.Demo.Factory;
using VirtualDataBase.Factory;
using VurtualDataBase.Interface;
using System.Linq;
using DomainModel.Time;

namespace VirtualDataBase.Demo
{
    internal class WorkerData : IWorkerData
    {
        private readonly List<IWorker> workerVirtualDataBase;

        public WorkerData(EndTask ET)
        {
            var worker1 = MemberFactory.CreateMember<WorkerOptions>(opt => opt
                .WithName("Dima")
                .WithLastName("Parascan")
                .WithGender("Man")
                .WithAge(22)
                .WithPosition("student"));

            var worker2 = MemberFactory.CreateMember<WorkerOptions>(opt => opt.WithName("Alex")
                .WithLastName("Caimacan")
                .WithGender("Man")
                .WithPosition("Mechanic"));


            var worker3 = MemberFactory.CreateMember<WorkerOptions>(opt => opt.WithName("Alice")
                .WithLastName("Curu")
                .WithGender("Women")
                .WithPosition("student"));

            var worker4 = MemberFactory.CreateMember<WorkerOptions>(opt => opt.WithName("Nikita")
                .WithLastName("Degteariov")
                .WithGender("Man")
                .WithAge(26)
                .WithPosition("Sisadmin"));

            var admin = MemberFactory.CreateMember<AdminOptions>(opt => opt.WithName("Denis")
                .WithLastName("Purcalov")
                .WithGender("Man")
                .WithAge(37), ET);

            var admin2 = MemberFactory.CreateMember<AdminOptions>(opt => opt.WithName("Anton")
                .WithLastName("Prohorov")
                .WithGender("Man")
                .WithAge(45), ET);

            workerVirtualDataBase = new List<IWorker> {worker1, worker2, worker3, worker4, admin, admin2};
        }

        public List<T> GetDataBase<T>() where T: IWorker
        {
            return workerVirtualDataBase.OfType<T>().ToList();
        }

    }
}