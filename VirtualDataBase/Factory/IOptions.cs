using DomainModel.Time;
using DomainModel.Workers;

namespace VirtualDataBase.Factory
{
    internal interface IOptions
    {
        IOptions WithName(string name);
        IOptions WithLastName(string lastName);
        IOptions WithAge(int? Age);
        IOptions WithGender(string gender);
        IOptions WithPosition(string v);
        IWorker Apply(EndTask ET);
    }
}