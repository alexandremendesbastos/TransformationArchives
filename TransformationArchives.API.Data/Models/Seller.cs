using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformationArchives.API.Data.Models
{
    public class Seller
    {
        public Seller() { }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Manager { get; set; }
    }
}
