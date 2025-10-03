using Microsoft.AspNetCore.Mvc;

namespace JadooTravel.ViewComponents.Default
{
    public class _DefaultFooterViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
