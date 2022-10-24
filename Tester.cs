using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDDdotZIP
{
	public class Tester
	{
		[Theory]
		[InlineData(1, "odd")]
		[InlineData(2, "even")] 
		[InlineData(7, "prime")]
		public void TestOddOrEven(int input, string expected)
		{
			OddEven oe = new();

			string actual = oe.OddOrEven(input);

			Assert.Equal(expected, actual);
		}



		[Theory]
		[InlineData(-1, "no negatives")]
		[InlineData(1, "I")]
		[InlineData(99, "XCIX")]
		[InlineData(1990, "MCMXC")]
		public void TestRomanNums(int input, string expected)
		{
			RomanNums rn = new();

			string actual = rn.RomanNumerals(input);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData("1234567", false)]
		[InlineData("", false)]
		[InlineData("abcdefghi", false)]
		[InlineData("abcdefgh1", false)]
		[InlineData("ABCDEFGH1", false)]
		[InlineData("Abcdefgh1", true)]
		public void Verify(string input, bool expected)
		{
			Password pword = new();

			bool actual = pword.Verify(input);

			Assert.Equal(expected, actual);
		}



		[Theory]
		[InlineData(1234, "one thousand two hundred and thirty-four")]
		[InlineData(1, "one")]
		[InlineData(17, "seventeen")]
		[InlineData(199, "one hundred and ninety-nine")]
		public void TestNTE(int input, string expected)
		{
			NumToEnglish nte = new();

			string actual = nte.NumberToEnglish(input);

			Assert.Equal(expected, actual);
		}
	}
}