using Data;
using Data.Interfaces;
using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private transportdbContext dataContext;
        protected transportdbContext DataContext
        {
            get
            {
                return dataContext = dbFactory.DataContext;
            }
        }

        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }
        public void CommitAsync()
        {
            dataContext.SaveChangesAsync();
        }

        private IPlanningRepository planningRepository;
        public IPlanningRepository PlanningRepository
        {
            get { return planningRepository = new PlanningRepository(dbFactory); ; }
        }
        private ISubscriptionRepository subscriptionRepository;

        public ISubscriptionRepository SubscriptionRepository
        {
            get { return subscriptionRepository = new SubscriptionRepository(dbFactory); ; }
        }


        private IPaiementRepository paiementRepository;
        public IPaiementRepository PaiementRepository
        {
            get { return paiementRepository = new PaiementRepository(dbFactory); ; }
        }

        public void Dispose()
        {
            DataContext.Dispose();
        }
        public IRepositoryBaseAsync<T> getRepository<T>() where T : class
        {
            IRepositoryBaseAsync<T> repo = new RepositoryBase<T>(dbFactory);
            return repo;
        }

        private ICityRepository cityRepository;
        public ICityRepository CityRepository
        {
            get { return cityRepository = new CityRepository(dbFactory); ; }
        }

    }
}
