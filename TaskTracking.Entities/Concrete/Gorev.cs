using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.Entities.Interfaces;

namespace TaskTracking.Entities.Concrete
{
    public class Gorev : ITablo
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
        public DateTime OlusturulmaTarih { get; set; } = DateTime.Now;

        public int AciliyetId { get; set; }
        public Aciliyet Aciliyet { get; set; }

        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }


        public List<Rapor> Raporlar { get; set; }
    }
}
