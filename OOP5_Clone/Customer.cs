using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Clone
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer copy()
        {
            return MemberwiseClone() as Customer;
        }
    }
}
