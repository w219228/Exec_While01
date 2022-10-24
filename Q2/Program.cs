using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num1 = 300;
			int num2 = 1;
			
			while (num1>=num2)
			{
				if(num1%num2 ==0)
				{
					Console.WriteLine(num2);
				}
				num2++;
			}
		}
	}
}
