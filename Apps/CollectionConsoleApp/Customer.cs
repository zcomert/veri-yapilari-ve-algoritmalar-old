using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    public class Customer
    {
        public int Id { get; set; }
        public String? FullName { get; set; } = String.Empty;

        public override string ToString()
        {
            return $"{Id, -4} {FullName,-20}";
        }
    }
}
