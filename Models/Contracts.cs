using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Classes
{
	public  class Contracts
	{
		private int number;
		private DateTime conclusion_date;
		private DateTime valid_date;
		private string executor;
		private string customer;
		// Предполагается, что свойства будут реализовывать валидацию
		public int Number { get => number; set => number = value; }
		public DateTime Conclusion_date { get => conclusion_date; set => conclusion_date = value; }
		public DateTime Valid_date { get => valid_date; set => valid_date = value; }
		public string Executor { get => executor; set => executor = value; }
		public string Customer { get => customer; set => customer = value; }
		//TODO: 
		// Сделать реализацию
		public Contracts()
        {
            
        }
    }
}
