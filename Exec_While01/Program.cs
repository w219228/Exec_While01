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
			while(num1<num2)
			{
				num1++;
				sum += num1;
				if (sum > num2)
				{
					break;
				}
				
			}
			Console.WriteLine(num1);
		}
	}
}
