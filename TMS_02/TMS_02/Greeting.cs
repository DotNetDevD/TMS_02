using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_02
{
    internal class Greeting
    {
        ElementA a;
        ElementB b;
        public void HelloWorld()
        {
            a = new();
            b = new();
            a.Hello();
            b.World();
        }
    }
}
