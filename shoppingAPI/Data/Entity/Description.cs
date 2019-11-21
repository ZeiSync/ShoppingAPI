namespace shoppingAPI.Data.Entity
{
    public class ProductDescription
    {
        public int ProductDescriptionId { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string ImgUrl { get; set; }
        public string HtmlDescription { get; set; }
        public string TextDescription { get; set; }
    }
}