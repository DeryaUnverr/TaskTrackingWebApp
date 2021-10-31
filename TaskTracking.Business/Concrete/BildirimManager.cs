using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.Business.Interfaces;
using TaskTracking.DataAccess.Interfaces;
using TaskTracking.Entities.Concrete;

namespace TaskTracking.Business.Concrete
{
    public class BildirimManager : IBildirimService
    {
        private readonly IBildirimDal _bildirimDal;
        public BildirimManager(IBildirimDal bildirimDal)
        {
            _bildirimDal = bildirimDal;
        }

        public List<Bildirim> GetirHepsi()
        {
            return _bildirimDal.GetirHepsi();
        }

        public Bildirim GetirIdile(int id)
        {
            return _bildirimDal.GetirIdile(id);
        }

        public List<Bildirim> GetirOkunmayanlar(int AppUserId)
        {
            return _bildirimDal.GetirOkunmayanlar(AppUserId);
        }

        public int GetirOkunmayanSayisiileAppUserId(int AppUserId)
        {
            return _bildirimDal.GetirOkunmayanSayisiileAppUserId(AppUserId);
        }

        public void Guncelle(Bildirim tablo)
        {
            _bildirimDal.Guncelle(tablo);
        }

        public void Kaydet(Bildirim tablo)
        {
            _bildirimDal.Kaydet(tablo);
        }

        public void Sil(Bildirim tablo)
        {
            _bildirimDal.Sil(tablo);
        }
    }
}
