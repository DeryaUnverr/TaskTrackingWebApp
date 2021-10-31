using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.DataAccess.Interfaces;
using TaskTracking.Entities.Concrete;

namespace TaskTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAciliyetRepository : EfGenericRepository<Aciliyet>, IAciliyetDal
    {
    }
}
