using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Student student = new Student();

            Console.WriteLine("Adınızı daxil edin: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Soyadınızı daxil edin: ");
            student.Surname = Console.ReadLine();

            Console.WriteLine("Doğum tarixini daxil edin: ");
            student.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Adınız: {0}",student.Name);
            Console.WriteLine("Soyadınız: {0}", student.Surname);
            Console.WriteLine("Doğum tarixiniz: {0}", student.DateOfBirth.ToString("dd MMMM yyyy"));

            Console.ReadLine();
        }
    }
}
