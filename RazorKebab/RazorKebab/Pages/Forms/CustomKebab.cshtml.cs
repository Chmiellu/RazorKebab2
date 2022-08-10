using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorKebab.Models;

namespace RazorKebab.Pages.Forms
{
    public class CustomKebabModel : PageModel
    {
        [BindProperty]
        public KebabyModel Kebab { get; set; }
        public float KebabPrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            KebabPrice = Kebab.BasePrice;
            if (Kebab.Cheese) KebabPrice += 2;
            if (Kebab.DoubleMeat) KebabPrice += 3;
            if (Kebab.Lettuce) KebabPrice += 1;
            if (Kebab.Jalapeno) KebabPrice += 2;
            if (Kebab.Fries) KebabPrice += 2;

            return RedirectToPage("/Checkout/Checkout", new { Kebab.KebabName,KebabPrice});

        }
    }
}
