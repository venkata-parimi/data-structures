using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
	public class LinkedList
	{
		public Node head;
		
		public void printLinkedList()
		{
			if (head == null)
			{
				Console.WriteLine("The  Linked list is empty. create a linked list with some data and then try to print the same");
				return;
			}
			Node current = head;
			while (current != null)
			{
				Console.WriteLine("Node data is {0}", current.data);
				current = current.next;
			}
			Console.WriteLine("Done with the printing of the Linked list. try some other operation now");
		}

		public void createRandomLinkedList(int size)
		{
			if (size <= 0)
			{
				Console.WriteLine("Dude try some positive integer for the creation of a linked list with some values in it...");
			}

			Node headNode = new Node(Utilities.GetRandomNumber());
			Node currentNode = headNode;
			for (int i = 0; i < size - 1; i++)
			{
				Node temp = currentNode;
				temp.next = new Node(Utilities.GetRandomNumber());
				currentNode = temp.next;
			}

			Console.WriteLine("Dude done with the creation of linked list for the given size...");
			this.head = headNode;
		}

		public void InserNodeAtTheStart(int data)
		{
			Node currentNode = new Node(Utilities.GetRandomNumber());
			if (this.head == null)
			{
				Console.WriteLine("The  Linked list is empty.the new node created will be the head and the linked list");
				this.head = currentNode;
				return;
			}
		}

		public void InserNodeAtTheEnd(int data)
		{
			Node newNode = new Node(Utilities.GetRandomNumber());
			if (this.head == null)
			{
				Console.WriteLine("The  Linked list is empty. create a linked list with some data and then try to print the same");
				this.head = newNode;
				return;
			}
			Node current = this.head;
			while (current.next!= null)
			{
				current = current.next;
			}
			current.next = newNode;
			Console.WriteLine("Done bro... Added the linked list at the end");
		}


		public void InsertNodeAfterGivenNode(Node givenNode, int data)
		{
			Node newNode = new Node(Utilities.GetRandomNumber());
			if (this.head == null || givenNode ==null)
			{
				Console.WriteLine("The  Linked list is empty or the given node is null");
				this.head = newNode;
				return;
			}
			Node current = this.head;
			while (current != null)
			{
				if (current.data == givenNode.data)
				{
					newNode.next = current.next;
					current.next = newNode;
				}
				current = current.next;
			}
			current.next = newNode;
			Console.WriteLine("Done bro... Added the linked list at the end");
		}

		public void DeleteNodeWithGivenData(int data)
		{
			if (this.head == null)
			{
				Console.WriteLine("The  Linked list is empty");
				return ;
			}
			Node current = this.head;
			Node previousElement = null;
			while (current != null && current.data!=data)
			{
				previousElement = current;
				current = current.next;
			}

			if (current == null)
			{
				Console.WriteLine("Sorry bro... Could not find the element you are asking for ");
			}

			previousElement.next = current.next;
			Console.WriteLine("Sorry bro... Could not find the element you are asking for ");
		}

		public void DeleteNodeAtGivenIndex(int indexToStop)
		{
			if (this.head == null)
			{
				Console.WriteLine("The  Linked list is empty");
				return;
			}
			Node current = this.head;
			Node previousElement = null;
			int counter = 0;
			while (current != null && counter != indexToStop)
			{
				previousElement = current;
				current = current.next;
				counter++;
			}

			if (current == null || counter <indexToStop)
			{
				Console.WriteLine("Sorry bro... Could not find the element you are asking for ");
			}

			previousElement.next = current.next;
			Console.WriteLine("Found the element you are asking for and deleted it");
		}

		public int GetTheLenghtOfLinkedListIteratively()
		{
			int length = 0;
			if (this.head == null)
			{
				Console.WriteLine("The  Linked list is empty");
				return 0;
			}

			Node current = this.head;
			while (current != null)
			{
				current = current.next;
				length++;
			}

			return length;
		}

		public int GetTheLenghtOfLinkedListRecursively(Node node)
		{
			if (node == null)
			{
				return 0;
			}

			return 1 + GetTheLenghtOfLinkedListRecursively(node.next);
		}

		public Node RetrieveNodeWithGivenDataIteratively(int data)
		{
			if (this.head == null)
			{
				Console.WriteLine("The  Linked list is empty");
				return null;
			}

			Node current = this.head;
			while (current != null)
			{
				if (current.data == data)
				{
					Console.WriteLine("Done bro... found the element ");
					return current;
				}
				current = current.next;
			}
			Console.WriteLine("Sorry bro... Could not find the element you are asking for ");
			return null;
		}

		public Boolean RetrieveNodeWithGivenDataRecursively(Node node, int data)
		{
			if (node == null)
			{
				Console.WriteLine("Sorry bro... Could not find the element you are asking for ");
				return false;
			}

			if(node.data==data)
			{
				Console.WriteLine("Cool bro... Finally found the element you are asking for ");
				return true;
			}

			return RetrieveNodeWithGivenDataRecursively(node.next, data);
		}

		public void SwapTwoNodesWithGivenData(int swap1, int swap2)
		{
			if (this.head == null)
			{
				Console.WriteLine("The  Linked list is empty");
				return;
			}

			Node previousForSwap1 = null;
			Node previousForSwap2 = null;
			Node currentForSwap1 = this.head, currentForSwap2 = this.head;
			while (currentForSwap1 != null && currentForSwap1.data != swap1)
			{
				previousForSwap1 = currentForSwap1;
				currentForSwap1 = currentForSwap1.next;
			}

			while (currentForSwap2 != null && currentForSwap2.data != swap2)
			{
				previousForSwap2 = currentForSwap2;
				currentForSwap2 = currentForSwap2.next;
			}

			if (currentForSwap1 == null || currentForSwap2 == null)
			{
				Console.WriteLine("One of the elements provided in the input is not  existing in the linkedlist");
				return;
			}

			if (previousForSwap1 != this.head)
			{
				previousForSwap1.next = currentForSwap2;
			}

			if (previousForSwap2 != this.head)
			{
				previousForSwap2.next = currentForSwap1;
			}

			Node tempNode = currentForSwap2.next;
			currentForSwap2.next = currentForSwap1.next;
			currentForSwap1.next = tempNode;
			Console.WriteLine("Successfully swapped the two nodes for the given data in the linked list");

			// Directly swap the data
			/*currentForSwap1.data = swap2;
			currentForSwap2.data = swap1;*/
			return;
		}

		public int RetrieveNodeAtGivenIndex(int indexToStop)
		{
			if (this.head == null)
			{
				Console.WriteLine("The  Linked list is empty");
				return -1;
			}
			Node current = this.head;
			int counter = 0;
			while (current != null && counter != indexToStop)
			{
				current = current.next;
				counter++;
			}

			if (current == null || counter < indexToStop)
			{
				Console.WriteLine("Sorry bro... Could not find the element you are asking for ");
			}

			Console.WriteLine("Found an element at the index you are looking for ");
			return current.data;
		}
	}
}
