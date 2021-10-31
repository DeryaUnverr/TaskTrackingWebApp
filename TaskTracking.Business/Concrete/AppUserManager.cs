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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _userDal;
        public AppUserManager(IAppUserDal userDal)
        {
            _userDal = userDal;
        }


        public List<AppUser> GetirAdminOlmayanlar()
        {
            return _userDal.GetirAdminOlmayanlar();
        }

        public List<AppUser> GetirAdminOlmayanlar(out int toplamSayfa, string aranacakKelime, int aktifSayfa)
        {
            return _userDal.GetirAdminOlmayanlar(out toplamSayfa, aranacakKelime, aktifSayfa);
        }

        public List<DualHelper> GetirEnCokGorevdeCalisanPersoneller()
        {
            return _userDal.GetirEnCokGorevdeCalisanPersoneller();
        }

        public List<DualHelper> GetirEnCokGorevTamamlamisPersoneller()
        {
            return _userDal.GetirEnCokGorevTamamlamisPersoneller();
        }
    }
}
