using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
	class Subtraction
	{
		public double numberOne;
		public double numberTwo;
		public double answer;

		public void GetFirstNumber()
		{
			Console.WriteLine("Enter First Number: ");

			numberOne = Convert.ToInt32(Console.ReadLine());
		}

		public void GetSecondNumber()
		{
			Console.WriteLine("Enter Second Number: ");

			numberTwo = Convert.ToInt32(Console.ReadLine());
		}

		public void GetAnswer()
		{
			answer = numberOne - numberTwo;

			Console.WriteLine($"Answer Is: {answer}");
		}
	}
}
