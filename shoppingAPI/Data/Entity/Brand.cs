using System.Collections.Generic;

namespace shoppingAPI.Data.Entity
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}