

using Microsoft.AspNetCore.Mvc;

namespace Foody.Presentation.Components.DefaultComponents
{
    public class _DefaultNavbarSectionComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}