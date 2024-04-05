using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformationArchives.API.Data.Models
{
    public class Sales
    {
        public Sales() { }

        public Guid Id { get; private set; }
        public Guid ProductId { get; private set; }
        public Guid SellerId { get; private set; }
        public Guid CustomerId { get; private set; }
    }
}
