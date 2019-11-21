using shoppingAPI.Data.Entity;
using shoppingAPI.Model.Profiles;

namespace shoppingAPI.Model
{
    public class ProductModels
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public bool Popularity { get; set; } = false;
        public double Price { get; set; }

        public int Quantities { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Branch { get; set; }

        public DescriptionModel ProductDescription { get; set; }

        public SpectificationModel Spectification { get; set; }

        public ShoppingCartItem ShoppingCartItem { get; set; }
    }
}