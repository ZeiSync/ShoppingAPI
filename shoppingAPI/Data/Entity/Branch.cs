using System.Collections.Generic;

namespace shoppingAPI.Data.Entity
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}