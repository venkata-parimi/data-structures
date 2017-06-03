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
			LinkedList linkedList = new LinkedList();
			linkedList.createRandomLinkedList(10);
			linkedList.printLinkedList();
			Console.ReadLine();
		}
	}
}
