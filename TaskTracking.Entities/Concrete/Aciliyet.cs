using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.Entities.Interfaces;

namespace TaskTracking.Entities.Concrete
{
    public class Aciliyet : ITablo
    {
        public int Id { get; set; }
        public string Tanim { get; set; }

        public List<Gorev> Gorevler { get; set; }
    }
}
