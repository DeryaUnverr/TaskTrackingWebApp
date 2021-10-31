﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskTracking.Business.Interfaces;
using TaskTracking.DTO.DTOs.AciliyetDtos;
using TaskTracking.Entities.Concrete;
using TaskTracking.WebUI.StringInfo;

namespace TaskTracking.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class AciliyetController : Controller
    {
        private readonly IAciliyetService _aciliyetService;
        private readonly IMapper _mapper;
        public AciliyetController(IAciliyetService aciliyetService, IMapper mapper)
        {
            _mapper = mapper;
            _aciliyetService = aciliyetService;
        }

        public IActionResult Index()
        {
            TempData["Active"] = TempdataInfo.Aciliyet;
            return View(_mapper.Map<List<AciliyetListDto>>(_aciliyetService.GetirHepsi()));
        }

        public IActionResult EkleAciliyet()
        {
            TempData["Active"] = TempdataInfo.Aciliyet;
            return View(new AciliyetAddDto());
        }

        [HttpPost]
        public IActionResult EkleAciliyet(AciliyetAddDto model)
        {
            if (ModelState.IsValid)
            {
                _aciliyetService.Kaydet(new Aciliyet()
                {
                    Tanim = model.Tanim
                });

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult GuncelleAciliyet(int id)
        {
            TempData["Active"] = TempdataInfo.Aciliyet;
            return View(_mapper.Map<AciliyetUpdateDto>(_aciliyetService.GetirIdile(id)));
        }

        [HttpPost]
        public IActionResult GuncelleAciliyet(AciliyetUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _aciliyetService.Guncelle(new Aciliyet
                {
                    Id = model.Id,
                    Tanim = model.Tanim
                });

                return RedirectToAction("Index");
            }
            return View(model);

        }
    }
}
