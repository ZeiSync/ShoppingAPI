﻿namespace shoppingAPI.Data.Entity
{
    public class Quantity
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantities { get; set; }

        public int Popularity { get; set; }
    }
}