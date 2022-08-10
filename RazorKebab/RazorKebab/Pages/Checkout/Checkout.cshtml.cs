using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorKebab.Data;
using RazorKebab.Models;

namespace RazorKebab.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        
        public string KebabName { get; set; }
        public float KebabPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
		{
            _context = context;
		}
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(KebabName))
            {
                KebabName = ImageTitle;
            }

            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            KebabOrder kebabOrder = new KebabOrder();
            kebabOrder.KebabName = KebabName;
            kebabOrder.BasePrice=KebabPrice;

            _context.KebabOrders.Add(kebabOrder);
            _context.SaveChanges();


        }
    }
}
