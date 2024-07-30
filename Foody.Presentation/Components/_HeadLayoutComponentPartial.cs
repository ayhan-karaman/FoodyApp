
using Microsoft.AspNetCore.Mvc;

namespace Foody.Presentation.ViewComponents
{
    public class _HeadLayoutComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}