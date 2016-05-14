using Data.Infrastructure;
using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Service
    {
        public class SubscriptionService : ISubscriptionService
    {
            static public DatabaseFactory dbFactory = new DatabaseFactory();
            UnitOfWork utwk = new UnitOfWork(dbFactory);
            public void AddSubscription(subscription a)
            {
                utwk.SubscriptionRepository.Add(a);
                utwk.Commit();
            }
            public List<subscription> getAllSubscriptions()
            {
                return utwk.SubscriptionRepository.GetAll().ToList();
            }
             public subscription getSubscriptionById(int i)
            {
            //subscription s = subscriptions.Find(c => c.id == i);
            //return s;
            return utwk.getRepository<subscription>().Get(d => d.id == i);
            }

        public void Delete(subscription s)
        {
            utwk.SubscriptionRepository.Delete(s);
        }
        public void SaveChange()
        {
            utwk.Commit();
        }
        public void Dispose()
        {
            utwk.Dispose();
        }
    }

        public interface ISubscriptionService
    {
            void AddSubscription(subscription a);
            List<subscription> getAllSubscriptions();
            subscription getSubscriptionById(int id);
            void SaveChange();
            void Delete(subscription s);
    }
    }
