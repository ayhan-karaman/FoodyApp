
using Microsoft.AspNetCore.Mvc;

namespace Foody.Presentation.Components
{
    public class _MainPanelLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}