using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
	public static class Utilities
	{
		public static int FindTheMaxNode(Node root)
		{
			if (root == null)
			{
				Console.WriteLine("There is n data available in the tree. Hence returning ");
				return 0;
			}
			int result = root.data;
			int leftTreeResult = FindTheMaxNode(root.left);
			int rightTreeResult = FindTheMaxNode(root.right);
			if (leftTreeResult > result)
			{
				result = leftTreeResult;
			}
			if (rightTreeResult > result)
			{
				result = rightTreeResult;
			}
			return result;
		}

		public static int FindTheMinNode(Node root)
		{
			if (root == null)
			{
				Console.WriteLine("There is n data available in the tree. Hence returning ");
				return 0;
			}
			int result = root.data;
			int leftTreeResult = FindTheMaxNode(root.left);
			int rightTreeResult = FindTheMaxNode(root.right);
			if (leftTreeResult < result)
			{
				result = leftTreeResult;
			}
			if (rightTreeResult < result)
			{
				result = rightTreeResult;
			}
			return result;
		}

		public static bool SearchForAKeyUsingRecursion(Node root, int data)
		{
			if (root == null)
			{
				Console.WriteLine("There is no data available in this node. Hence returning ");
				return false;
			}
			if (root.data == data)
			{
				Console.WriteLine("Found the element you are looking for.. ");
				return true;
			}
			bool result = SearchForAKeyUsingRecursion(root.left, data);
			if(!result)
			{
				result = SearchForAKeyUsingRecursion(root.right, data);
			}
			return result;
		}

		public static void PrintInOrderTraversal(Node node)
		{
			if (node == null)
			{
				return;
			}
			PrintInOrderTraversal(node.left);
			Console.WriteLine(node.data);
			PrintInOrderTraversal(node.right);
		}

		// Pending
		public static bool SearchForAKeyUsingInOrderTraversalAndStack(Node root, int data)
		{
			if (root == null)
			{
				Console.WriteLine("There is no data available in this node. Hence returning ");
				return false;
			}
			Stack<Node> stack = new Stack<Node>();
			Node currentNode = root;
			Node rootNode = root;
			stack.Push(currentNode);
			while(stack.Count>0)
			{
				currentNode = stack.Pop();
				if(currentNode.data==data)
				{
					return true;
				}

				if(currentNode.right!=null)
				{
					stack.Push(currentNode.right);
				}
				stack.Push(currentNode);
				if (currentNode.left != null)
				{
					stack.Push(currentNode.left);
				}

			;
			}
			
			return false;
		}

		public static void StoreSumOfAllNodesInLeftSubTree(Node root)
		{

		}

		public static bool SearchForAKeyUsingLevelOrderTraversalAndQueue(Node root, int data)
		{
			if (root == null)
			{
				Console.WriteLine("There is no data available in this node. Hence returning ");
				return false;
			}

			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(root);
			while (queue.Count > 0)
			{
				Node currentNode = queue.Dequeue();
				if (currentNode.data == data)
				{
					Console.WriteLine("Found the element you are looking for.. ");
					return true;
				}
				if (currentNode.left != null)
				{
					queue.Enqueue(currentNode.left);
				}
				if (currentNode.right != null)
				{
					queue.Enqueue(currentNode.right);
				}
			}
			return false;
		}

		public static int CalculateHeightOfTree(Node root)
		{
			int height = 0;
			if (root == null)
			{
				return height;
			}
			int leftTreeHeight = CalculateHeightOfTree(root.left);
			int rightTreeHeight = CalculateHeightOfTree(root.right);
			if (leftTreeHeight>rightTreeHeight)
			{
				height = leftTreeHeight + 1;
			}
			else
			{
				height = rightTreeHeight + 1;
			}
			return height;
		}

		public static BinaryTree CreateBinaryTree()
		{
			BinaryTree tree = new BinaryTree();
			tree.root = new Node(10);
			Node leftTree = new Node(5);
			leftTree.left= new Node(3);
			leftTree.right = new Node(8);
			Node rightTree = new Node(20);
			rightTree.left = new Node(19);
			rightTree.right = new Node(30);
			tree.root.left = leftTree;
			tree.root.right = rightTree;
			//leftTree.left.left = new Node(2);
			//leftTree.left.right = new Node(4);
			//leftTree.right.left = new Node(7);
			//leftTree.right.right = new Node(9);
			//rightTree.left.left = new Node(15);
			//rightTree.left.right = new Node(16);
			//rightTree.right.left = new Node(25);
			//rightTree.right.right = new Node(35);

			//tree.root = new Node(Utilities.GetDoubleDigitRandomNumber());
			//Node leftTree = new Node(Utilities.GetDoubleDigitRandomNumber());
			//leftTree.left = new Node(Utilities.GetDoubleDigitRandomNumber());
			//leftTree.right = new Node(Utilities.GetDoubleDigitRandomNumber());
			//Node rightTree = new Node(Utilities.GetDoubleDigitRandomNumber());
			//rightTree.left = new Node(Utilities.GetDoubleDigitRandomNumber());
			//rightTree.right = new Node(Utilities.GetDoubleDigitRandomNumber());
			//tree.root.left = leftTree;
			//tree.root.right = rightTree;
			//leftTree.left.left = new Node(Utilities.GetDoubleDigitRandomNumber());
			//leftTree.left.right = new Node(5);
			//rightTree.left.left = new Node(Utilities.GetDoubleDigitRandomNumber());
			//rightTree.left.right = new Node(Utilities.GetDoubleDigitRandomNumber());
			return tree;
		}

		private static Random randomNumber;

		public static int GetDoubleDigitRandomNumber()
		{
			if (randomNumber == null)
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
