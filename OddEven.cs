using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDdotZIP
{
	internal class OddEven
	{
		public string OddOrEven(int number)
		{
			for (int i = 2; i <= number / 2; i++)
			{
				if (!(number % i == 0))
				{
					return "prime";
				}
			}
			if (number % 2 == 0)
			{
				return "even";
			} else
			{
				return "odd";
			}
			
		}
	}
}
