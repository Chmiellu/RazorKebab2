using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorKebab.Data;
using RazorKebab.Models;

namespace RazorKebab.Pages
{
    public class OrdersModel : PageModel
    {
        public List<KebabOrder> KebabOrders = new List<KebabOrder>();
        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
		{
            _context = context; 
		}
        public void OnGet()
        {
            KebabOrders = _context.KebabOrders.ToList();
        }
    }
}
