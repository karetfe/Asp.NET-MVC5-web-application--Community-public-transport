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
    public class PlanningRepository : RepositoryBase<planning>, IPlanningRepository
    {
        public PlanningRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface IPlanningRepository : IRepository<planning>
    {

    }
}
