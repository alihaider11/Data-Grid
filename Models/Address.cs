using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data_Grid.Models
{
    public class Address
    {
        public string AddressID { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string StateProvinceID { get; set; }
        public string PostalCode { get; set; }
        public string SpatialLocation { get; set; }
        public string RowID { get; set; }
        public string ModifiedDate { get; set; }
    }
}
