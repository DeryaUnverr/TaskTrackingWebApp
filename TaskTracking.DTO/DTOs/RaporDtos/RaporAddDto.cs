using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.Entities.Concrete;

namespace TaskTracking.DTO.DTOs.RaporDtos
{
    public class RaporAddDto
    {
        //[Display(Name = "Tanım :")]
        //[Required(ErrorMessage = "Tanim alanı boş geçilemez")]
        public string Tanim { get; set; }
        //[Display(Name = "Detay :")]
        //[Required(ErrorMessage = "Detay alanı boş geçilemez")]
        public string Detay { get; set; }
        public Gorev Gorev { get; set; }
        public int GorevId { get; set; }
    }
}
