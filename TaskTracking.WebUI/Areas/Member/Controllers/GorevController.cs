using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskTracking.Business.Interfaces;
using TaskTracking.DTO.DTOs.GorevDtos;
using TaskTracking.Entities.Concrete;
using TaskTracking.WebUI.BaseControllers;
using TaskTracking.WebUI.StringInfo;

namespace TaskTracking.WebUI.Areas.Member.Controllers
{
    [Authorize(Roles = RoleInfo.Member)]
    [Area(AreaInfo.Member)]
    public class GorevController : BaseIdentityController
    {
        private readonly IGorevService _gorevService;

        private readonly IMapper _mapper;
        public GorevController(IGorevService gorevService, UserManager<AppUser> userManager, IMapper mapper) : base(userManager)
        {
            _mapper = mapper;

            _gorevService = gorevService;
        }
        public async Task<IActionResult> Index(int aktifSayfa = 1)
        {
            TempData["Active"] = TempdataInfo.Gorev;
            var user = await GetirGirisYapanKullanici();


            var gorevler = _mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarlaTamamlanmayan(out int toplamSayfa, user.Id, aktifSayfa));


            ViewBag.ToplamSayfa = toplamSayfa;
            ViewBag.AktifSayfa = aktifSayfa;

            return View(gorevler);
        }
    }
}
