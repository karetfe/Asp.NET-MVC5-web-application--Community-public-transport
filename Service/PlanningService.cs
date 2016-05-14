using Data.Infrastructure;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class PlanningService : IPlanningService
    {
        private List<planning> plannings = null;

        public PlanningService()
        {
        }

        static public DatabaseFactory dbFactory = new DatabaseFactory();

        UnitOfWork utwk = new UnitOfWork(dbFactory);
        public void AddPlanning(planning a)
        {
            utwk.PlanningRepository.Add(a);
            utwk.Commit();
        }

        public List<planning> getAllPlannings()
        {
            return utwk.PlanningRepository.GetAll().ToList();
        }
        public planning getPlanningById(int i)
        {
            //planning p = plannings.Find(c => c.id == i);
            //return p;
            return utwk.getRepository<planning>().Get(d => d.id == i);
        }
  
        public void Delete(planning p)
        {
        utwk.PlanningRepository.Delete(p);
        }
        public void SaveChange()
        {
            utwk.Commit();
        }
        public void Dispose()
        {
            utwk.Dispose();
        }
        public void UpdatePlanning(planning planning)
        {
            utwk.PlanningRepository.Update(planning);
            utwk.Commit();
        }

    }

    public interface IPlanningService : IDisposable
    {
        void AddPlanning(planning a);
        List<planning> getAllPlannings();
        planning getPlanningById(int id);
        void SaveChange();
        void Delete(planning p);
        void UpdatePlanning(planning planning);
    }

    
}
