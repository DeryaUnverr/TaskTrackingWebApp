using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using TaskTracking.Entities.Interfaces;

namespace TaskTracking.Entities.Concrete
{
    public class AppUser : IdentityUser<int>, ITablo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Picture { get; set; } = "default.png";


        public List<Bildirim> Bildirimler { get; set; }
        public List<Gorev> Gorevler { get; set; }
    }
}
