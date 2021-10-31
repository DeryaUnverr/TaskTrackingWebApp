using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracking.DTO.DTOs.AciliyetDtos
{
    public class AciliyetAddDto
    {
        /* 
                 [Display(Name="Tanım")]
        [Required(ErrorMessage ="Tanım alanı boş geçilemez")]
             
             */
        public string Tanim { get; set; }
    }
}
