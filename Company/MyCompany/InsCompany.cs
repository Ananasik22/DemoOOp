using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    internal class InsCompany : Company
    {
       int counts; //количество застрахованных лиц
        int summaplus; // сумма страховых взносов
        int summaminus; // сумма страховых выплат
        public InsCompany(string name, int persons, 
            int mony, int counts, int summaplus, int summaminus) 
            : base(name, persons, mony)
        {

        }
        
       //-----------описание методов-----------------
       //вычисление среднего размера страховых взносов
        public int averageInsSumma()
        {
            return summaplus / counts;
        }
    }
}

