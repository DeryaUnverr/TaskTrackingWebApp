using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskTracking.Business.Interfaces;
using TaskTracking.DTO.DTOs.AppUserDtos;
using TaskTracking.Entities.Concrete;

namespace TaskTracking.WebUI.ViewComponents
{
    public class Wrapper : ViewComponent
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;
        public Wrapper(UserManager<AppUser> userManager, IBildirimService bildirimService, IMapper mapper)
        {
            _mapper = mapper;
            _bildirimService = bildirimService;
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var identityUser = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var model = _mapper.Map<AppUserListDto>(identityUser);


            var bildirimler = _bildirimService.GetirOkunmayanlar(model.Id).Count;

            ViewBag.BildirimSayisi = bildirimler;
            var roles = _userManager.GetRolesAsync(identityUser).Result;

            if (roles.Contains("Admin"))
            {
                return View(model);
            }
            return View("Member", model);

        }
    }
}
