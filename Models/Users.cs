using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter.Classes
{
	public class Users
	{
		private string login;
		private string password;
		private string role;
		// Предполагается, что свойства будут реализовывать валидацию
		public string Login
		{
			get => login;
			set => login = value;
		}

		public string Password
		{
			get => password;
			set => password = value;
		}

		public string Role
		{
			get => role;
			set => role = value;
		}

        public Users(string login, string password, string role)
        {
			Login = login;
			Password = password;
			Role = role;
        }
    }
}
