
using Microsoft.AspNetCore.Mvc;

namespace Foody.Presentation.Components
{
    public class _CustomTemplateLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}