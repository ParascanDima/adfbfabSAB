using Ninject;
using VirtualDataBase.Demo;
using VurtualDataBase.Interface;

namespace Infrastructure
{
    internal static class ServiceLocator
    {
        private static readonly IKernel _kernel = new StandardKernel();

        public static void RegisterAll()
        {
            _kernel.Bind<IWorkerData>().To<WorkerData>();
        }

        public static T Resolve<T>()
        {
            return _kernel.Get<T>();
        }
    }
}