using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrmSystem
{
   public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public char HouseNumberLetter { get; set; }
        public int FlatNumber { get; set; }
        public string PostCode { get; set; }
        
        public override string ToString()
        {
            string returnString = string.Empty;
            returnString = string.Format("{0} {1}{2}-{3}, {4}, {5}, {6}", Street, HouseNumber, HouseNumberLetter, FlatNumber, City, PostCode, Country);

        return returnString;
        }
        
    }
}
