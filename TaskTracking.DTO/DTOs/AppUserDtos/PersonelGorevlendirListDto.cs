using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracking.DTO.DTOs.GorevDtos;


namespace TaskTracking.DTO.DTOs.AppUserDtos
{
    public class PersonelGorevlendirListDto
    {
        public AppUserListDto AppUser { get; set; }
        public GorevListDto Gorev { get; set; }
    }
}
