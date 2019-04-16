using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
	class Calculator
	{
		public int choice;

		public void GetChoice()
		{
			Console.WriteLine($"Choice Is: ");

			choice = int.Parse(Console.ReadLine());

			if (choice == 1)
			{
				Addition add = new Addition();
				add.GetFirstNumber();
				add.GetSecondNumber();
				add.GetAnswer();
				Console.ReadLine();
			}
			else if (choice == 2)
			{
				Subtraction subract = new Subtraction();
				subract.GetFirstNumber();
				subract.GetSecondNumber();
				subract.GetAnswer();
				Console.ReadLine();
			}
			else if (choice == 3)
			{
				Multiplication multiply = new Multiplication();
				multiply.GetFirstNumber();
				multiply.GetSecondNumber();
				multiply.GetAnswer();
				Console.ReadLine();
			}
			else if (choice == 4)
			{
				Divison divide = new Divison();
				divide.GetFirstNumber();
				divide.GetSecondNumber();
				divide.GetAnswer();
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Incorrect Choice");
			}
		}
	}
}
