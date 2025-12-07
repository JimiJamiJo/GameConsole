using GameConsole.Base;
using GameConsole.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
	internal class LoginScreen : Screen
	{
		public LoginScreen() : base("Login Page")
		{
		}
		public override void Show()
		{
			string username, password;
			base.Show();
			CenterText("Enter Login Info");
			Console.Write("Enter your username: ");
			username = Console.ReadLine();

			Console.Write("Enter password: ");
			password = Console.ReadLine();

			if(UserDb.Login(username, password) != null)
			{
				Console.WriteLine("Login succesfull!");
 			}
            else
            {
				Console.WriteLine("Login Failed");
            }
        }
	}
}
