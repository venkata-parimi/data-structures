using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
	public class BasicMathLinkedList
	{
		public void VerifyMathAddOperationOnSingleLinkedLists(int firstLinkedListSize, int secondLinkedListSize, LinkedListOperation operationType)
		{
			LinkedList firstLinkedList = this.createRandomLinkedList(firstLinkedListSize);
			this.PrintLinkedListData(firstLinkedList);
			LinkedList secondLinkedList = this.createRandomLinkedList(secondLinkedListSize);
			this.PrintLinkedListData(secondLinkedList);
			switch (operationType)
			{
				case LinkedListOperation.Add:
					this.AddDataOfTwoSlingleLinkedLists(firstLinkedList, secondLinkedList);
					break;
				case LinkedListOperation.Subtract:
					this.SubtractDataOfTwoSlingleLinkedLists(firstLinkedList, secondLinkedList);
					break;
				case LinkedListOperation.Multiply:
					this.MultiplyDataOfTwoSingleLinkedLists(firstLinkedList, secondLinkedList);
					break;
				default:
					Console.WriteLine("I am going to relax and have fun.. As all work and no fun makes jack a dull boy :)");
					break;
			}
			
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
			LinkedList resultSingleLinkedList = PerformAddOnReverseLinkedLists(firstSingleLinkedList, secondSingleLinkedList);
			resultSingleLinkedList = Utilities.ReverseALinkedListWithoutStack(resultSingleLinkedList);
			Console.WriteLine("Completed the process of adding two single linked lists...Going to print it now");
			this.PrintLinkedListData(resultSingleLinkedList);
		}

		public void SubtractDataOfTwoSlingleLinkedLists(LinkedList firstSingleLinkedList, LinkedList secondSingleLinkedList)
		{
			Console.WriteLine("Going to start the Subtract operation on the two given linked lists...");
			int firstLLMSB = firstSingleLinkedList.head != null ? firstSingleLinkedList.head.data : 0;
			int secondLLMSB = secondSingleLinkedList.head != null ? secondSingleLinkedList.head.data : 0;
			firstSingleLinkedList = Utilities.ReverseALinkedListWithoutStack(firstSingleLinkedList);
			secondSingleLinkedList = Utilities.ReverseALinkedListWithoutStack(secondSingleLinkedList);
			LinkedList resultSingleLinkedList = new LinkedList();
			Node firstSingleLinkedListNode = firstSingleLinkedList.head;
			Node secondSingleLinkedListNode = secondSingleLinkedList.head;
			Node resultSingleLinkedListNode = resultSingleLinkedList.head;
			Node currentNode = resultSingleLinkedListNode;
			int lengthOfFirstLinkedList = GetTheLenghtOfLinkeEdList(firstSingleLinkedList);
			int lengthOfSecondLinkedList = GetTheLenghtOfLinkeEdList(secondSingleLinkedList);
			if (lengthOfFirstLinkedList < lengthOfSecondLinkedList || (lengthOfFirstLinkedList == lengthOfSecondLinkedList && firstLLMSB < secondLLMSB))
			{
				Console.WriteLine("As of now i dont know how to subtract large from small number");
				return;
			}

			while (firstSingleLinkedListNode != null && secondSingleLinkedListNode != null)
			{
				int difference = 0;
				if (firstSingleLinkedListNode.data < secondSingleLinkedListNode.data)
				{
					if (firstSingleLinkedListNode.next != null)
					{
						difference = PerformSubtractOperation(10 + firstSingleLinkedListNode.data, secondSingleLinkedListNode.data);
						firstSingleLinkedListNode.next.data = firstSingleLinkedListNode.next.data - 1;
					}
					else
					{
						Console.WriteLine("As of now i dont know how to subtract large from small number");
						return;
					}
				}
				else
				{
					difference = PerformSubtractOperation(firstSingleLinkedListNode.data, secondSingleLinkedListNode.data);
				}

				if (currentNode == null)
				{
					Node tempNode = currentNode;
					resultSingleLinkedListNode = new Node(difference);
					currentNode = resultSingleLinkedListNode;
				}
				else
				{
					CreateNodeAndUpdateTheNextPointer(ref currentNode, difference);
				}

				firstSingleLinkedListNode = firstSingleLinkedListNode.next;
				secondSingleLinkedListNode = secondSingleLinkedListNode.next;
			}

			while (firstSingleLinkedListNode != null)
			{
				int difference = firstSingleLinkedListNode.data;
				CreateNodeAndUpdateTheNextPointer(ref currentNode, difference);
				firstSingleLinkedListNode = firstSingleLinkedListNode.next;
			}

			if (secondSingleLinkedListNode != null)
			{
				Console.WriteLine("As of now i dont know how to subtract large from small number");
				return;
			}

			resultSingleLinkedList.head = resultSingleLinkedListNode;
			resultSingleLinkedList = Utilities.ReverseALinkedListWithoutStack(resultSingleLinkedList);
			Console.WriteLine("Completed the process of subtracting two single linked lists...Going to print it now");
			this.PrintLinkedListData(resultSingleLinkedList);
		}

		public void MultiplyDataOfTwoSingleLinkedLists(LinkedList firstSingleLinkedList, LinkedList secondSingleLinkedList)
		{
			Console.WriteLine("Going to start the Multiply operation on the two given linked lists...");
			firstSingleLinkedList = Utilities.ReverseALinkedListWithoutStack(firstSingleLinkedList);
			secondSingleLinkedList = Utilities.ReverseALinkedListWithoutStack(secondSingleLinkedList);
			LinkedList resultSingleLinkedList = new LinkedList();

			Node firstSingleLinkedListNode = firstSingleLinkedList.head;
			Node resultSingleLinkedListNode = resultSingleLinkedList.head;
			Node currentNode = resultSingleLinkedListNode;
			int counter=0;

			while (firstSingleLinkedListNode != null)
			{
				LinkedList tempResultSingleLinkedList = new LinkedList();
				Node tempResultSingleLinkedListNode = tempResultSingleLinkedList.head;
				Node tempCurrentNode = tempResultSingleLinkedListNode;
				Node secondSingleLinkedListNode = secondSingleLinkedList.head;
				int carryForward = 0;
				if (counter>0)
				{
					tempResultSingleLinkedListNode = new Node(0);
					tempCurrentNode = tempResultSingleLinkedListNode;
					AppendNodesWithZeroData(ref tempCurrentNode, counter);
				}

				while (secondSingleLinkedListNode != null)
				{
					int sum = 0;
					carryForward = PerformMultiply(firstSingleLinkedListNode.data, secondSingleLinkedListNode.data, carryForward, out sum);
					if (tempCurrentNode == null)
					{
						Node tempNode = tempCurrentNode;
						tempResultSingleLinkedListNode = new Node(sum);
						tempCurrentNode = tempResultSingleLinkedListNode;
					}
					else
					{
						CreateNodeAndUpdateTheNextPointer(ref tempCurrentNode, sum);
					}

					secondSingleLinkedListNode = secondSingleLinkedListNode.next;
				}

				if (carryForward > 0)
				{
					CreateNodeAndUpdateTheNextPointer(ref tempCurrentNode, carryForward);
				}
				counter++;
				tempResultSingleLinkedList.head = tempResultSingleLinkedListNode;
				resultSingleLinkedList= PerformAddOnReverseLinkedLists(resultSingleLinkedList, tempResultSingleLinkedList);
				firstSingleLinkedListNode = firstSingleLinkedListNode.next;
			}
			resultSingleLinkedList = Utilities.ReverseALinkedListWithoutStack(resultSingleLinkedList);
			Console.WriteLine("Completed the process of multiplying two single linked lists...Going to print it now");
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

		private void AppendNodesWithZeroData(ref Node linkedListNode, int counter)
		{
			for (int i = 0; i < counter-1; i++)
			{
				CreateNodeAndUpdateTheNextPointer(ref linkedListNode, 0);
			}
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

		private LinkedList PerformAddOnReverseLinkedLists(LinkedList firstSingleLinkedList, LinkedList secondSingleLinkedList)
		{
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
				if (currentNode == null)
				{
					resultSingleLinkedListNode = new Node(sum);
					currentNode = resultSingleLinkedListNode;
				}
				else
				{
					CreateNodeAndUpdateTheNextPointer(ref currentNode, sum);
				}

				firstSingleLinkedListNode = firstSingleLinkedListNode.next;
			}

			while (secondSingleLinkedListNode != null)
			{
				int sum = 0;
				carryForward = PerformSum(0, secondSingleLinkedListNode.data, carryForward, out sum);
				if (currentNode == null)
				{
					resultSingleLinkedListNode = new Node(sum);
					currentNode = resultSingleLinkedListNode;
				}
				else
				{
					CreateNodeAndUpdateTheNextPointer(ref currentNode, sum);
				}

				secondSingleLinkedListNode = secondSingleLinkedListNode.next;
			}

			if (carryForward > 0)
			{
				CreateNodeAndUpdateTheNextPointer(ref currentNode, carryForward);
			}

			resultSingleLinkedList.head = resultSingleLinkedListNode;
			return resultSingleLinkedList;
		}

		private int PerformMultiply(int a, int b, int carryForward, out int sum)
		{
			int total = (a * b) + carryForward;
			carryForward = 0;
			sum = total;
			if (total >= 10)
			{
				sum = total % 10;
				carryForward = total / 10;
			}
			return carryForward;
		}

		private int PerformSubtractOperation(int a, int b)
		{
			return a-b;
		}

		private void CreateNodeAndUpdateTheNextPointer(ref Node linkedListNode, int data)
		{
			linkedListNode.next = new Node(data);
			linkedListNode = linkedListNode.next;
		}

		private int GetTheLenghtOfLinkeEdList(LinkedList linkedList)
		{
			int length = 0;
			Node linkedListNode = linkedList.head;
			while (linkedListNode!=null)
			{
				length++;
				linkedListNode = linkedListNode.next;
			}
			return length;
		}
	}
}
