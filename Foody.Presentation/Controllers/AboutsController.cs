using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Foody.Business;
using Foody.DataObjectTransfers.DTOs.AboutDtos;
using Foody.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Foody.Presentation.Controllers
{
    
    public class AboutsController : Controller
    {

        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutsController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _aboutService.TGetAll();
            var mappingValues = _mapper.Map<List<ResultAboutDto>>(values);
            return View(mappingValues);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto aboutDto)
        {
            var about = _mapper.Map<About>(aboutDto);
            _aboutService.TInsert(about);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAbout(int id)
        {
            _aboutService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var about = _aboutService.TGetById(id);
            var mappingAbout = _mapper.Map<UpdateAboutDto>(about);
            return View(mappingAbout);
        }

        [HttpPost]
        public IActionResult EditAbout(UpdateAboutDto aboutDto)
        {
            var about = _mapper.Map<About>(aboutDto);
            _aboutService.TUpdate(about);
            return RedirectToAction("Index");
        }
    }
}