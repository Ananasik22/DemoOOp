using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // создание объекта и вызов конструктора
            Company factory = new Company("Премьер", 100, 1000000);
            factory.show();
            Console.WriteLine("Средняя зарплата: " + factory.averageSalary());
            Console.WriteLine("Отчисления: " + factory.minus(13, 4));
            Console.WriteLine("Средняя зарплата?");
                int average = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество сотрудников: " + factory.maxPersons(average));
            
        }
    }
}
