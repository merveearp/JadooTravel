using Microsoft.AspNetCore.Mvc;

namespace JadooTravel.ViewComponents.Default
{
    public class _DefaultNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
