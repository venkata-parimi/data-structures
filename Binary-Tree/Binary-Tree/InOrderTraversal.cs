using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
	public class InOrderTraversal
	{
		public BinaryTree binaryTree = new BinaryTree();

		public void RecursiveInOrderTraversal(Node node)
		{
			if(node==null)
			{
				return;
			}
			RecursiveInOrderTraversal(node.left);
			Console.WriteLine(node.data);
			RecursiveInOrderTraversal(node.right);
		}

		public void IterativeInOrderTraversalUsingStack()
		{
			if (binaryTree.root == null)
			{
				return;
			}

			Stack<Node> stack = new Stack<Node>();
			Node currentNode = binaryTree.root;
			stack.Push(currentNode);
			currentNode = stack.Peek();
			while (currentNode.left != null)
			{
				currentNode = currentNode.left;
				stack.Push(currentNode);
			}
			while (stack.Count > 0)
			{
				currentNode = stack.Pop();
				Console.WriteLine(currentNode.data);
				if (currentNode.right != null)
				{
					currentNode = currentNode.right;
					stack.Push(currentNode);
					while (currentNode.left != null)
					{
						currentNode = currentNode.left;
						stack.Push(currentNode);
					}
				}
			}
		}

		public static void PerformInOrderTraversal()
		{
			InOrderTraversal inOrderTraversalTree = new InOrderTraversal();

			inOrderTraversalTree.binaryTree.root = new Node(1);
			inOrderTraversalTree.binaryTree.root.left = new Node(2);
			inOrderTraversalTree.binaryTree.root.right = new Node(3);
			inOrderTraversalTree.binaryTree.root.left.left = new Node(4);
			inOrderTraversalTree.binaryTree.root.left.right = new Node(5);

			Console.WriteLine("In order traversal of binary tree using Recursion is ");
			inOrderTraversalTree.RecursiveInOrderTraversal(inOrderTraversalTree.binaryTree.root);
			Console.WriteLine("");
			Console.WriteLine("In order traversal of binary tree using Iterative Approach is ");
			inOrderTraversalTree.IterativeInOrderTraversalUsingStack();
		}
	}
}
