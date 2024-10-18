
using Foody.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.Presentation.Components.DefaultComponents
{
    public class _DefaultSliderSectionComponentPartial:ViewComponent
    {
        private readonly ISliderService _sliderService;

        public _DefaultSliderSectionComponentPartial(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IViewComponentResult Invoke()
        {
            var sliders = _sliderService.TGetAll();
            return View(sliders);
        }
    }
}