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

			BasicMathLinkedList addOperationsLinkedList = new BasicMathLinkedList();
			addOperationsLinkedList.VerifyAddOperationOnSingleLinkedLists(2, 2);
			addOperationsLinkedList.VerifyAddOperationOnSingleLinkedLists(3, 2);
			Console.ReadLine();
		}
	}
}
