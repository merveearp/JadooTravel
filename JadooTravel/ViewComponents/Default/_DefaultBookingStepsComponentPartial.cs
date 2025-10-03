using Microsoft.AspNetCore.Mvc;

namespace JadooTravel.ViewComponents.Default
{
    public class _DefaultBookingStepsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
