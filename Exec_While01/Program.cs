using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_While01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num1 = 0;
			int num2 = 105;
			int sum = 0;
			while (num2 > sum)
			{
				num1++;
				sum += num1;
			}
			Console.WriteLine(num1);
		}
	}
}
