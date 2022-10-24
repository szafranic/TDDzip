using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDdotZIP
{
	internal class Password
	{

		public bool Verify(string password)
		{
			if (password.Length < 8
				|| password == "")
			{
				return false;
			}
			if (password.ToLower() == password ||
				password.ToUpper() == password)
			{
				return false;
			}
			if (!(password.Any(char.IsDigit)))
			{
				return false;
			}
			return true;
		}
	}
}
