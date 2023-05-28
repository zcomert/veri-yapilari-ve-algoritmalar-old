using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Doubly
{
    public class DbNode<T>
    {
        public T? Value { get; set; }

        public DbNode<T> Next { get; set; }
        public DbNode<T> Prev { get; set; }

        public DbNode(T? value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }

        public DbNode()
        {
            Next = null;
            Prev = null;
        }

        public override string? ToString()
        {
            return $"{Value}";
        }
    }
}
