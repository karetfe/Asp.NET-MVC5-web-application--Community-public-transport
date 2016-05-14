using Data.Infrastructure;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        IRepositoryBaseAsync<T> getRepository<T>() where T : class;
        void CommitAsync();


        IPlanningRepository PlanningRepository { get; }
        ISubscriptionRepository SubscriptionRepository { get; }
        IPaiementRepository PaiementRepository { get; }

        //ICityRepository PaiementRepository { get; }



    }
}
