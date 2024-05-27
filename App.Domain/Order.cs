using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain
{
     public class Order
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string OrderNumber {  get; set; }

        public string OrderDate { get; set; }
        public string OrderType { get; set; }
    }
}
