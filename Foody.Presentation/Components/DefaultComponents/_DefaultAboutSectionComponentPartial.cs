
using Foody.Business;
using Microsoft.AspNetCore.Mvc;

namespace Foody.Presentation.Components.DefaultComponents
{
    public class _DefaultAboutSectionComponentPartial:ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _DefaultAboutSectionComponentPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var abouts = _aboutService.TGetAll();
            return View(abouts);
        }
    }
}