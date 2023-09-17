using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Models
{
	public  class Schedule
	{
		private DateTime year;
		private DateTime month;
		private string municipality;
		// Предполагается, что свойства будут реализовывать валидацию
		public DateTime Year { get => year; set => year = value; }
		public DateTime Month { get => month; set => month = value; }
		public string  Municipality { get => municipality; set => municipality = value; }
		//TODO: 
		// Сделать реализацию
        public Schedule()
        {
            
        }
    }
}
