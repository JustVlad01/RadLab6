using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class Product
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int ReorderLevel { get; set; }
        public int ReorderQuantity { get; set; }
        public double UnitPrice { get; set; }
        public int StockOnHand { get; set; }
    }
}