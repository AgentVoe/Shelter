using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Classes
{
    public class Organization
    {
        public string orgname; // наиманование организации
        public int inn; // номер ИНН
        public int kpp; // номер КПП
        public string adress; // адрес организации
        public string orgtype; // тип организации
        public string ipyyr; // ип или юр лицо

        public string Orgname { get => orgname; set => orgname = value; }
        public int Inn { get => inn; set => inn = value; }
        public int Kpp { get => kpp; set => kpp = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Orgtype { get => orgtype; set => orgtype = value; }
        public string Ipyyr { get => ipyyr; set => ipyyr = value; }
    }
}