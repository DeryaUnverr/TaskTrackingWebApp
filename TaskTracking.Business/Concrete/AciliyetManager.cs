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
    public class AciliyetManager : IAciliyetService
    {
        private readonly IAciliyetDal _aciliyetDal;
        public AciliyetManager(IAciliyetDal aciliyetDal)
        {
            _aciliyetDal = aciliyetDal;
        }

        public List<Aciliyet> GetirHepsi()
        {
            return _aciliyetDal.GetirHepsi();
        }

        public Aciliyet GetirIdile(int id)
        {
            return _aciliyetDal.GetirIdile(id);
        }

        public void Guncelle(Aciliyet tablo)
        {
            _aciliyetDal.Guncelle(tablo);
        }

        public void Kaydet(Aciliyet tablo)
        {
            _aciliyetDal.Kaydet(tablo);
        }

        public void Sil(Aciliyet tablo)
        {
            _aciliyetDal.Sil(tablo);
        }
    }
}
