
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Foody.Presentation.Components
{
    public class _SidebarLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() =>  View();
    }
}