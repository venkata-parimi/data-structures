using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
	public class BasicMathLinkedList
	{

		public void VerifyAddOperationOnSingleLinkedLists(int firstLinkedListSize, int secondLinkedListSize)
		{
			LinkedList firstLinkedList = this.createRandomLinkedList(firstLinkedListSize);
			this.PrintLinkedListData(firstLinkedList);
			LinkedList secondLinkedList = this.createRandomLinkedList(secondLinkedListSize);
			this.PrintLinkedListData(secondLinkedList);
			this.AddDataOfTwoSlingleLinkedLists(firstLinkedList, secondLinkedList);
		}

		public LinkedList createRandomLinkedList(int size)
		{
			Console.WriteLine("About to start the creation of linked list for the given size...");
			LinkedList newLinkedList = new LinkedList();
			if (size <= 0)
			{
				Console.WriteLine("Dude try some positive integer for the creation of a linked list with some values in it...");
			}

			Node headNode = new Node(Utilities.GetSingleDigitRandomNumber());
			Node currentNode = headNode;
			for (int i = 0; i < size - 1; i++)
			{
				Node temp = currentNode;
				temp.next = new Node(Utilities.GetSingleDigitRandomNumber());
				currentNode = temp.next;
			}

			Console.WriteLine("Dude done with the creation of linked list for the given size...");
			newLinkedList.head = headNode;
			return newLinkedList;
		}

		public void AddDataOfTwoSlingleLinkedLists(LinkedList firstSingleLinkedList, LinkedList secondSingleLinkedList)
		{
			Console.WriteLine("Going to start the addition operation on the two given linked lists...");
			firstSingleLinkedList = Utilities.ReverseALinkedListWithoutStack(firstSingleLinkedList);
			secondSingleLinkedList = Utilities.ReverseALinkedListWithoutStack(secondSingleLinkedList);
			LinkedList resultSingleLinkedList = new LinkedList();
			int carryForward = 0;
			Node firstSingleLinkedListNode = firstSingleLinkedList.head;
			Node secondSingleLinkedListNode = secondSingleLinkedList.head;
			Node resultSingleLinkedListNode = resultSingleLinkedList.head;
			Node currentNode = resultSingleLinkedListNode;
			while (firstSingleLinkedListNode != null && secondSingleLinkedListNode != null)
			{
				int sum = 0;
				carryForward = PerformSum(firstSingleLinkedListNode.data, secondSingleLinkedListNode.data, carryForward, out sum);
				if (currentNode == null)
				{
					Node tempNode = currentNode;
					resultSingleLinkedListNode = new Node(sum);
					currentNode = resultSingleLinkedListNode;
				}
				else
				{
					CreateNodeAndUpdateTheNextPointer(ref currentNode, sum);
				}
			
				firstSingleLinkedListNode = firstSingleLinkedListNode.next;
				secondSingleLinkedListNode = secondSingleLinkedListNode.next;
			}

			while (firstSingleLinkedListNode != null)
			{
				int sum = 0;
				carryForward = PerformSum(firstSingleLinkedListNode.data, 0, carryForward, out sum);
				CreateNodeAndUpdateTheNextPointer(ref currentNode, sum);
				firstSingleLinkedListNode = firstSingleLinkedListNode.next;
			}

			while (secondSingleLinkedListNode != null)
			{
				int sum = 0;
				carryForward = PerformSum(0, secondSingleLinkedListNode.data, carryForward, out sum);
				CreateNodeAndUpdateTheNextPointer(ref currentNode, sum);
				secondSingleLinkedListNode = secondSingleLinkedListNode.next;
			}

			if(carryForward>0)
			{
				CreateNodeAndUpdateTheNextPointer(ref currentNode, carryForward);
			}

			resultSingleLinkedList.head = resultSingleLinkedListNode;
			resultSingleLinkedList = Utilities.ReverseALinkedListWithoutStack(resultSingleLinkedList);
			Console.WriteLine("Completed the process of adding two single linked lists...Going to print it now");
			this.PrintLinkedListData(resultSingleLinkedList);
		}

		private void PrintLinkedListData(LinkedList firstLinkedList)
		{
			Console.WriteLine("Just going to start the printing of the linked list..");
			Console.WriteLine("");
			Node headNode = firstLinkedList.head;
			if (headNode == null)
			{
				Console.WriteLine("If the list is empty I cant print anything here");
			}
			while (headNode != null)
			{
				Console.Write(headNode.data);
				headNode = headNode.next;
			}
			Console.WriteLine("");
			Console.WriteLine("Done with the printing of the linked list..");
		}

		private int PerformSum(int a, int b, int carryForward, out int sum)
		{
			int total = a + b + carryForward;
			carryForward = 0;
			sum = total;
			if (total >= 10)
			{
				sum = total % 10;
				carryForward = total / 10;
			}
			return carryForward;
		}

		private void CreateNodeAndUpdateTheNextPointer(ref Node linkedListNode, int data)
		{
			linkedListNode.next = new Node(data);
			linkedListNode = linkedListNode.next;
		}
	}
}
