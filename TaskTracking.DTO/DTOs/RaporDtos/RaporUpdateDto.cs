using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.Entities.Concrete;

namespace TaskTracking.DTO.DTOs.RaporDtos
{
    public class RaporUpdateDto
    {
        public int Id { get; set; }
        public string Tanim { get; set; }
        public string Detay { get; set; }
        public Gorev Gorev { get; set; }
        public int GorevId { get; set; }
    }
}
