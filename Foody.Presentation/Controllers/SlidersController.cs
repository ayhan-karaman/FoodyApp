using AutoMapper;
using Foody.Business.Abstract;
using Foody.DataObjectTransfers.DTOs.SliderDtos;
using Foody.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.Presentation.Controllers
{
    
    public class SlidersController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public SlidersController(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _sliderService.TGetAll();
            var mappingValues = _mapper.Map<List<ResultSliderDto>>(values);
            return View(mappingValues);
        }

        
        public IActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSlider(CreateSliderDto sliderDto)
        {
            var slider = _mapper.Map<Slider>(sliderDto);
            _sliderService.TInsert(slider);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSlider(int id)
        {
            _sliderService.TDelete(id);
            return RedirectToAction("Index");
        }

      
        [HttpGet]
        public IActionResult EditSlider(int id)
        {
            var slider = _sliderService.TGetById(id);
             var mappingSlider = _mapper.Map<UpdateSliderDto>(slider);
            return View(mappingSlider);
        }

        [HttpPost]
        public IActionResult EditSlider(UpdateSliderDto sliderDto)
        {
            var slider = _mapper.Map<Slider>(sliderDto);
           
            _sliderService.TUpdate(slider);
            return RedirectToAction("Index");
        }
    }
}