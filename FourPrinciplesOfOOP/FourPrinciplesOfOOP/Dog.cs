using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPrinciplesOfOOP
{
    class Dog:Animal
    {

        public Dog(string _name)
        {
            name = _name;
        }
        public override void Hello()
        {
            Console.WriteLine("Hello, i'm a dog, my name is " + name);
        }
    }
}
