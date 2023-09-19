using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Classes
{
    public class CatchAct
    {
        public int caid; //ca id = Catch Act id
        public int dogcount; // кол-во пойманных собак
        public int catcount; // кол-во пойманных кошек
        public int animalcount; // кол-во пойманных животных
        public string orgname; // название организации
        public DateTime catchDate; // дата отлова
        public string catchPurp; // цель отлова
        public int applicid; // applicid = Application ID это номер заявки на отлов
        public int mcid; // mcid = municipal contract id номер карточки муниципального контракта

    }
}

