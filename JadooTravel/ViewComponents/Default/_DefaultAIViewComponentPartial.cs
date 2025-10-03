using Microsoft.AspNetCore.Mvc;

namespace YourProjectNamespace.ViewComponents
{
    public class _DefaultAIViewComponentPartial : ViewComponent
    {
       
        public async Task<IViewComponentResult> InvokeAsync()
        {
          
            return View();
        }
    }
}
