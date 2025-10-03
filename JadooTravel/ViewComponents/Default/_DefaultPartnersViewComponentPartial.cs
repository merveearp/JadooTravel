using JadooTravel.Services.PartnerServices;
using Microsoft.AspNetCore.Mvc;

namespace JadooTravel.ViewComponents.Default
{
    public class _DefaultPartnersViewComponentPartial :ViewComponent
    {
        private readonly IPartnerService _partnerService;

        public _DefaultPartnersViewComponentPartial(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _partnerService.GetAllPartnerAsync();
            return View(values);
        }
    }
}
