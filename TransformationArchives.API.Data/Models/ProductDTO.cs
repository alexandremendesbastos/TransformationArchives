using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformationArchives.API.Data.Models
{
    public class ProductDTO
    {
        public ProductDTO() { }

        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Seller { get; set; }
    }
}
