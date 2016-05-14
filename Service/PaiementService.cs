using Data.Infrastructure;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public  class PaiementService: IPaiementService
    {
        static public DatabaseFactory dbFactory = new DatabaseFactory();
        UnitOfWork utwk = new UnitOfWork(dbFactory);

        public void AddPaiement(paiement a)
        {
            utwk.PaiementRepository.Add(a);
            utwk.Commit();
        }

        public List<paiement> getAllPaiements()
        {
            return utwk.PaiementRepository.GetAll().ToList();
        }
        public paiement getPaiementById(int i)
        {
           
            return utwk.getRepository<paiement>().Get(d => d.id == i);
        }

        public void Delete(paiement p)
        {
            utwk.PaiementRepository.Delete(p);
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

    public interface IPaiementService
    {
        void AddPaiement(paiement a);
        List<paiement> getAllPaiements();
        paiement getPaiementById(int id);
        void SaveChange();
        void Delete(paiement p);
    }
}