using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearmToTest
{
    public class MyNode
    {
        public int value;
        public int howManyBig;
        public MyNode next;
        public MyNode(int val)
        {
            value = val;
            howManyBig = 0;
            next = null;
        }
    }
}
