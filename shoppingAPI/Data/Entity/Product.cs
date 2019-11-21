namespace shoppingAPI.Data.Entity
{
    public class Product
    {
        //luk what i got
        //nothing
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public bool Popularity { get; set; } = false;
        public double Price { get; set; }

        //public int QuantityId { get; set; }
        public Quantity Quantity { get; set; }

        //public int DescriptionId { get; set; }
        public ProductDescription ProductDescription { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        //public int SpecificationId { get; set; }
        public Specification Specification { get; set; }

        public ShoppingCartItem ShoppingCartItem { get; set; }
    }
}