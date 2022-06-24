using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LLNode
    {
        public int Data { get; set; }
        public LLNode Next { get; set; } = null;

        public LLNode() { }

        public LLNode(int d) => Data = d;

        public override string ToString()
        {
            return Data.ToString();
        }
    }

}
