using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    internal class AvtoCompany : Company
    {
        public AvtoCompany(string name, int persons, int mony) : base(name, persons, mony)
        {
        }
        int count; //количество автомобилей
        int haul; // объём грузоперевозок
     //--------описание методов--------------------
     // определение среднего объема грузоперевозок
        public int averageAvto()
        {
            return haul / count;
        }
    } // конец описания класса AvtoCompany
}

