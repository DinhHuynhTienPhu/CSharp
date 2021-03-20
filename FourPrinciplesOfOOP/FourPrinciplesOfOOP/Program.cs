using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPrinciplesOfOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            tính trừu tượng: trong abstact class Animal có phương thức Hello, nghĩa là ta định nghĩa mọi con vật đều có thể Hello;
            tính đóng gói và bảo mật: name của các con vật không thể dược truy cập từ ngoài vào;
            tính kế thừa: Cat và Dog kế thừa từ Animal, nên cũng sẽ có name và Hello();
            tính đa hình: Hello() của 2 class Dog và Cat có cách thực thi khác nhau, nhưng khi ta sử dụng thì có thể gọi 1 phương thức là Hello;


    */
            Cat cat = new Cat("meo so 1");
            Dog dog = new Dog("cho so 1");
            

            cat.Hello();
            dog.Hello();
            Console.ReadKey();

        }
    }
}
