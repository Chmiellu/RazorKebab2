namespace RazorKebab.Models
{
    public class KebabyModel
    {
        public string ImageTitle { get; set; }
        public string KebabName { get; set; }
        public float BasePrice { get; set; } = 10;
        public bool SpicySauce{ get;set; }
        public bool MildSauce { get; set; }
        public bool MixSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Jalapeno { get; set; }
        public bool Fries { get; set; }
        public bool DoubleMeat { get; set; }
        public bool Lettuce { get; set; }
        public float FinalPrice { get; set; }


    }
}
