using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    internal class Company
    {
        public string name;
        public int persons;
        public int mony;
        //конструктор
        public Company(string name, int persons, int mony)
        {
            this.name = name;// this используется для ссылки на объект
            this.persons = persons;
            this.mony = mony;
        }
        public void show()
        {
            Console.WriteLine("В компании " + name + " трудятся " + persons + " сотрудников ");
            Console.WriteLine("Фонд зарплаты: " + mony);
        }
        public int averageSalary()
        {
            return mony / persons;
        }
        public int maxPersons(int salary)
        {
            return mony / salary;
        }
        public int minus (int minus1/*Налог в %*/, int minus2 /*отчисление в ПФ в %*/)
        {
            return mony*(minus1 + minus2)/100;
        }
    }//конец описания класса
}
