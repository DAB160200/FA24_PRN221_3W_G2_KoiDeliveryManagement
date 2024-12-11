using KoiDeliveryManagement.Repository.Model;
using KoiDeliveryManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KoiDeliveryManagement.RazorWebApp.Pages.Deliveries
{
    public class IndexModel : PageModel
    {
        private readonly DeliveryService _deliveryService;

        public IndexModel(DeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        public IList<Delivery> Deliveries { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchOrderId { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchDeliveryStaffId { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchLocation { get; set; }

        public async Task OnGetAsync()
        {
            var deliveries = await _deliveryService.GetAll();

            if (!string.IsNullOrEmpty(SearchOrderId) && int.TryParse(SearchOrderId, out int orderId))
            {
                deliveries = deliveries.Where(d => d.OrderId == orderId).ToList();
            }

            if (!string.IsNullOrEmpty(SearchDeliveryStaffId) && int.TryParse(SearchDeliveryStaffId, out int deliveryStaffId))
            {
                deliveries = deliveries.Where(d => d.DeliveryStaffId == deliveryStaffId).ToList();
            }

            if (!string.IsNullOrEmpty(SearchLocation))
            {
                deliveries = deliveries.Where(d => d.Location.Contains(SearchLocation)).ToList();
            }

            Deliveries = deliveries;
        }
    }
}
