using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskTracking.Business.Interfaces;
using TaskTracking.Entities.Concrete;
using TaskTracking.WebUI.BaseControllers;
using TaskTracking.WebUI.StringInfo;

namespace TaskTracking.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class HomeController : BaseIdentityController
    {
        private readonly IGorevService _gorevService;
        private readonly IBildirimService _bildirimService;
        private readonly IRaporService _raporService;
        public HomeController(IGorevService gorevService, IBildirimService bildirimService, UserManager<AppUser> userManager, IRaporService raporService) : base(userManager)
        {
            _raporService = raporService;
            _bildirimService = bildirimService;
            _gorevService = gorevService;
        }

        /* 
         - Atanmayı Bekleyen Gorev Sayısı
         - Tamamlanmış Görev Sayısı
         - Okunmamış Bildirim Sayısı
         - Toplam Yazılmış Rapor Sayısı
         */
        public async Task<IActionResult> Index()
        {

            var user = await GetirGirisYapanKullanici();
            TempData["Active"] = TempdataInfo.Anasayfa;
            ViewBag.AtanmayiBekleyenGorevSayisi = _gorevService.GetirGorevSayisiAtanmayiBekleyen();

            ViewBag.TamamlanmisGorevSayisi = _gorevService.GetirGorevTamamlanmis();

            ViewBag.OkunmamisBildirimSayisi = _bildirimService.GetirOkunmayanSayisiileAppUserId(user.Id);

            ViewBag.ToplamRaporSayisi = _raporService.GetirRaporSayisi();
            return View();
        }

    }
}
