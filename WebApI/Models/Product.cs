using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApI.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int CategoryId { get; set; }

        [JsonIgnore] // => needs this ti stop the loop for prodects with refernce to category but cat ref product
        public virtual Category Category { get; set; }

    }
}
