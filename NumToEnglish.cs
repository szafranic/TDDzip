using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDdotZIP
{
	internal class NumToEnglish
	{
		public string NumberToEnglish(int dollar)
		{
			string[] ones = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
			string[] teens = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
			string[] tens = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

			char[] broken = dollar.ToString().Trim().ToCharArray();
			Array.Reverse(broken);
			string builder = "";
			int i = 0;
			if (dollar >= 10000)
			{
				builder += tens[broken[i]] + "thousand ";
				i++;
			}
			if (dollar >= 1000)
			{
				builder += ones[broken[i]]+"thousand ";
				i++;
			}
			if (dollar >= 100)
			{
				builder += ones[broken[i]] + "hundred and ";
				i++;
			}

			if (dollar >= 10)
			{
				builder += tens[broken[i]] + "-";
				i++;
			}
			int pos = broken[i];
			builder += ones[pos];
			return builder;
		}
	}
}
