using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using TaskTracking.DataAccess.Interfaces;
using TaskTracking.Entities.Concrete;

namespace TaskTracking.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBildirimRepository : EfGenericRepository<Bildirim>, IBildirimDal
    {
        public List<Bildirim> GetirOkunmayanlar(int AppUserId)
        {
            using var context = new TodoContext();
            return context.Bildirimler.Where(I => I.AppUserId == AppUserId && !I.Durum).ToList();
        }

        public int GetirOkunmayanSayisiileAppUserId(int AppUserId)
        {
            using var context = new TodoContext();
            return context.Bildirimler.Count(I => I.AppUserId == AppUserId && !I.Durum);
        }
    }
}
