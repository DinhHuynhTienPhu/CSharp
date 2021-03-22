using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Dinh Huynh Tien Phu", "19120325", 10);
            student.Add("KHTN", "CNTT", "19CTT2");
            Student student2 = new Student("Nguyen Anh Tuan", "19120416", 9);
            student2.Add("KHTN", "CNTT", "19CTT2");
            Student student3 = new Student("Doan Anh Khoi", "19120111", 5);
            student3.Add("KHTN", "CNTT", "19CTT3");
            Student student4 = new Student("Nguyen Thi Loan", "19120225", 10);
            student4.Add("UIT", "CNTT", "IT_01");
            Console.WriteLine("\n*********Khoi tao danh sach luc dau:***********\n");
            Controller.PrintAll();


            student4.Update(_department: "CNSH", _class: "SH_03");
            Console.WriteLine("\n*********Sau khi thay doi nganh hoc sinh vien Nguyen Thi Loan:***********\n");
            Controller.PrintAll();


            student.Update(_name: "Tien Phu Dep Trai Sieu Cap Vu Tru");
            Console.WriteLine("\n***********Sau khi thay doi ten sinh vien Dinh Huynh Tien Phu:*********\n");
            Controller.PrintAll();

            student.Remove();
            Console.WriteLine("\n***********Sau khi remove sinh vien Tien Phu Dep Trai Sieu Cap Vu Tru:***********\n");
            Controller.PrintAll();

            Student student5 = new Student("Tran Dac Toan", "19120400", 8);
            student5.Add("UIT", "CNSH", "SH_03");
            student4.Update(_university:"HUTECH",_department: "CNSH", _class: "SH_04");
            Console.WriteLine("\n*********Sau khi them Tran Dac Toan va update Nguyen Thi Loan*********\n");
            Controller.PrintAll();


            Console.ReadKey();

        }
        

    }
}
