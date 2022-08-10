using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorKebab.Models;

namespace RazorKebab.Pages
{
    public class kebabModel : PageModel
    {
        public List<KebabyModel> fakeKebabDB = new List<KebabyModel>()
        {
            new KebabyModel(){
                ImageTitle="classic",
                KebabName="classic",
                BasePrice=10,
                MildSauce=true,
                FinalPrice=10},
            new KebabyModel(){
                ImageTitle="lettuce",
                KebabName="lettuce",
                BasePrice=10,
                MildSauce=true,
                Lettuce=true,
                FinalPrice=11},
            new KebabyModel(){
                ImageTitle="meat",
                KebabName="meat",
                BasePrice=10,
                MildSauce=true,
                DoubleMeat=true,
                FinalPrice=13},
            new KebabyModel(){
                ImageTitle="cheese",
                KebabName="cheese", 
                BasePrice=10, 
                MildSauce=true,
                Cheese=true,
                FinalPrice=12},
            new KebabyModel(){
                ImageTitle="american",
                KebabName="american",
                BasePrice=10,
                MildSauce=true,
                Fries=true,
                FinalPrice=12},
            new KebabyModel(){
                ImageTitle="mega",
                KebabName="mega",
                BasePrice=10,
                MildSauce=true,
                FinalPrice=18},
        };
        public void OnGet()
        {
        }
    }
}
