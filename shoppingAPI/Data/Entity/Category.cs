using System.Collections.Generic;

namespace shoppingAPI.Data.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public IEnumerable<Branch> Branches { get; set; }
    }
}