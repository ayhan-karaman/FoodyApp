
using Microsoft.AspNetCore.Mvc;

namespace Foody.Presentation.Components
{
    public class _FooterLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}