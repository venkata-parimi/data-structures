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

		public static LinkedList ReverseALinkedListWithoutStack(LinkedList linkedList)
		{
			Node headNode = linkedList.head;
			if (headNode == null)
			{
				Console.WriteLine("when the linked list is empty how do you expect me to reverse..");
			}
			Node currentNode = headNode;
			Node previousNode = null;
			Node nextNode = null;
			while (currentNode != null)
			{
				nextNode = currentNode.next;
				currentNode.next = previousNode;
				previousNode = currentNode;
				currentNode = nextNode;
			}

			linkedList.head = previousNode;

			Console.WriteLine("Done with the reverse of the linked list..");
			return linkedList;
		}

		public static void PrintLinkedListData(LinkedList resultSingleLinkedList)
		{
			Console.WriteLine("Just going to start the printing of the linked list..");
			Node headNode = resultSingleLinkedList.head;
			if (headNode == null)
			{
				Console.WriteLine("If the list is empty I cant print anything here");
			}
			while (headNode != null)
			{
				Console.WriteLine("Data in the node is {0}", headNode.data);
				headNode = headNode.next;
			}
			Console.WriteLine("Done with the printing of the linked list..");
		}
	}
	public enum LinkedListOperation
	{
		None =0,
		Add=1,
		Subtract=2,
		Multiply=3
	}
}
