using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.Entities.Concrete;

namespace TaskTracking.DTO.DTOs.GorevDtos
{
    public class GorevListDto
    {
        public int Id { get; set; }

        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
        public DateTime OlusturulmaTarih { get; set; }

        public int AciliyetId { get; set; }
        public Aciliyet Aciliyet { get; set; }
    }
}
