using System;
using System.Collections.Generic;
using System.Text;

namespace SeboNasCanelas.Win.AppObjects
{
    public class BaseProduct
    {
        public int ID { get; set; }

        public string Category { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int StockQuantity { get; set; }

        public decimal Price { get; set; }

        public DateTime AddedOn { get; set; }
    }
}