using Data.Infrastructure;
using Data.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class CityService : ICityService
    {
       static public DatabaseFactory dbFactory = new DatabaseFactory();
       UnitOfWork utwk = new UnitOfWork(dbFactory);
        public void AddCity(city city)
        {
            utwk.CityRepository.Add(city);
            utwk.Commit();
        }

        public List<city> getAllCity()
        {
            return utwk.CityRepository.GetAll().ToList();
        }

        public void deleteCity(city city)
        {
            utwk.CityRepository.Delete( city);
            utwk.Commit();
        }

        public city GetById(long id)
        {
            city city = new city();
            city= utwk.CityRepository.GetById(id);
            return city;
        }

        public void UpdateCity(city city)
        {
            utwk.CityRepository.Update(city);
            utwk.Commit();
        }
    }

   public interface ICityService
    {
       List<city> getAllCity();
       void AddCity(city city);
       void UpdateCity(city city);
       void deleteCity(city city);
       city GetById(long id);
       
   }
}
