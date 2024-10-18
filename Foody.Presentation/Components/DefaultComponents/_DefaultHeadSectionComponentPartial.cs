
using Microsoft.AspNetCore.Mvc;

namespace Foody.Presentation.Components.DefaultComponents
{
    public class _DefaultHeadSectionComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }    
    }
}