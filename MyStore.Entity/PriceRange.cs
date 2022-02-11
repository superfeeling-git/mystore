using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Entity
{
    public class PriceRange
    {
        public int PriceRangeId { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
