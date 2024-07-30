
using Microsoft.AspNetCore.Mvc;

namespace Foody.Presentation.Components
{
    public class _ScriptsLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}