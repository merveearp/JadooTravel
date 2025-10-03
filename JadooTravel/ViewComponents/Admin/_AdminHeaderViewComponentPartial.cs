using Microsoft.AspNetCore.Mvc;

namespace JadooTravel.ViewComponents.Admin
{
    public class _AdminHeaderViewComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
