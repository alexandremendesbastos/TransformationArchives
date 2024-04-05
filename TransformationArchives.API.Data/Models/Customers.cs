using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformationArchives.API.Data.Models
{
    public class Customers
    {
        public Customers() { }

        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public DateTime BirthDay { get; set; }
        public string Zipcode { get; set; }
        public bool HaveCard { get; set; }
    }
}
