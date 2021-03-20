using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPrinciplesOfOOP
{
    class Cat:Animal

    {
        public Cat(string _name) {
            name = _name;
        }

        public override void Hello()
        {
            Console.WriteLine("Hello, I'm a cat, my name is " + name);
        }
    }
}
