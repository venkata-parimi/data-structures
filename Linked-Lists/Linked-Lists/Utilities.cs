using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
	static class Utilities
	{
		private static Random randomNumber;

		
		public static int GetDoubleDigitRandomNumber()
		{
			if(randomNumber== null)
			{
				randomNumber = new Random();
			}

			return randomNumber.Next(10, 99);
		}

		public static int GetSingleDigitRandomNumber()
		{
			if (randomNumber == null)
			{
				randomNumber = new Random();
			}

			return randomNumber.Next(0, 9);
		}

		public static int GetTripleDigitRandomNumber()
		{
			if (randomNumber == null)
			{
				randomNumber = new Random();
			}

			return randomNumber.Next(100, 999);
		}
	}
}
