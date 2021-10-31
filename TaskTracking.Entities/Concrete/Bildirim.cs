using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.Entities.Interfaces;

namespace TaskTracking.Entities.Concrete
{
    public class Bildirim : ITablo
    {
        public int Id { get; set; }

        public string Aciklama { get; set; }
        public bool Durum { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }


    }
}
