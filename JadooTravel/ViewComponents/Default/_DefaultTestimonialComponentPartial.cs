using JadooTravel.Services.CategoryServices;
using JadooTravel.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace JadooTravel.ViewComponents.Default
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {

        private readonly ITestimonialService  _testimonialService;

        public _DefaultTestimonialComponentPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialService.GetAllTestimonialAsync();
            return View(values);
        }
       
    }
}
