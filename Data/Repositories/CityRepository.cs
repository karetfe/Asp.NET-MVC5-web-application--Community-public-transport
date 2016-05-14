

using Data.Infrastructure;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data.Models;
using Domain.Entities;

namespace  Data.Repositories
{
    public class CityRepository : RepositoryBase<city>, ICityRepository
    {
        public CityRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface ICityRepository : IRepository<city>
    {

    }
}
