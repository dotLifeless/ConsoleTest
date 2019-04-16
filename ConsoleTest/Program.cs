using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculator calculate = new Calculator();

			calculate.GetChoice();

			Console.ReadLine();
		}
	}
}
