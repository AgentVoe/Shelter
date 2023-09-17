using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Classes
{
	public class Animals
	{
		private string category;
		private string sex;
		private string breed;
		private string hair;
		private string color;
		private string ears;
		private string tail;
		private string special_signs;
		private string identification_mark;
		private int number_of_chip;
		private string settlement;
		private string catch_act;
		// Предполагается, что свойства будут реализовывать валидацию
		public string Category { get => category; set => category = value; }
		public string Sex { get => sex; set => sex = value; }
		public string Breed { get => breed; set => breed = value; }
		public string Hair { get => hair; set => hair = value; }
		public string Color
		{
			get => color; set => color = value;
		}
		public string Ears
		{
			get => ears; set => ears = value;
		}
		public string Tail
		{
			get => tail; set => tail = value;
		}
		public string Special_signs
		{
			get => special_signs; set => special_signs = value;
		}
		public string Identification_mark {get => identification_mark; set => identification_mark = value; }
		public int Number_of_chip { get => number_of_chip; set => number_of_chip = value;}
		public string Settlement { get => settlement; set => settlement = value;
		}
		public string CatchAct { get => catch_act; set => catch_act = value;
		}
		//TODO: 
		// Сделать реализацию
        public Animals()
        {
            
        }
    }
}
