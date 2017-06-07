using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			//LinkedList linkedList = new LinkedList();
			//linkedList.createRandomLinkedList(10);
			//linkedList.printLinkedList();

			BasicMathLinkedList basicMathOperationsLinkedList = new BasicMathLinkedList();
			Console.WriteLine("Please enter the number for performing the corresponding operation. \n 1. Add \n 2. Subtract \n 3. Multiply");
			var inputOption = Console.ReadLine();
			int parsedInputValue = 0;
			Int32.TryParse(inputOption, out parsedInputValue);
			LinkedListOperation operationName = (LinkedListOperation)parsedInputValue;
			if (parsedInputValue > 0 && parsedInputValue < 4)
			{
				Console.WriteLine("*************Going to test the {0} operations for single lists of size 2 /2 ***********", operationName.ToString());
				Console.WriteLine("");
				basicMathOperationsLinkedList.VerifyMathAddOperationOnSingleLinkedLists(2, 2, operationName);
				Console.WriteLine("*************Completed the test to {0} operations for single lists of size 2 /2 ***********", operationName.ToString());
				Console.WriteLine("");
				Console.WriteLine("*************Going to test the {0} operations for single lists of size 3 /2 ***********", operationName.ToString());
				Console.WriteLine("");
				basicMathOperationsLinkedList.VerifyMathAddOperationOnSingleLinkedLists(3, 2, operationName);
				Console.WriteLine("*************Completed test to {0} operations for single lists of size 3 /2 ***********", operationName.ToString());
				Console.WriteLine("");
				Console.WriteLine("*************Going to test the {0} operations for single lists of size 2 /3 ***********", operationName.ToString());
				Console.WriteLine("");
				basicMathOperationsLinkedList.VerifyMathAddOperationOnSingleLinkedLists(2, 3, operationName);
				Console.WriteLine("*************Completed test to {0} operations for single lists of size 2 /3 ***********", operationName.ToString());
				Console.WriteLine("");
			}
			else
			{
				Console.WriteLine("I am going to relax and have fun.. As all work and no fun makes jack a dull boy :)");
			}
			Console.ReadLine();
		}
	}
}
