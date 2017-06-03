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

		
		public static int GetRandomNumber()
		{
			if(randomNumber== null)
			{
				randomNumber = new Random();
			}

			return randomNumber.Next(0, 1000);
		}
	}
}
