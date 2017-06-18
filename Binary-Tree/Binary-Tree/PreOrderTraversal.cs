using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
	class PreOrderTraversal
	{
		public BinaryTree binaryTree = new BinaryTree();

		public void RecursivePreOrderTraversal(Node node)
		{
			if (node == null)
			{
				return;
			}
			Console.WriteLine(node.data);
			RecursivePreOrderTraversal(node.left);
			RecursivePreOrderTraversal(node.right);
		}

		public void IterativePreOrderTraversalUsingStack()
		{
			if (binaryTree.root == null)
			{
				return;
			}

			Stack<Node> stack = new Stack<Node>();
			Node currentNode = binaryTree.root;
			stack.Push(currentNode);
			while (stack.Count > 0)
			{
				currentNode = stack.Pop();
				Console.WriteLine(currentNode.data);
				if (currentNode.right != null)
				{
					stack.Push(currentNode.right);
				}
				if (currentNode.left != null)
				{
					stack.Push(currentNode.left);
				}
			}
		}

		public static void PerformPreOrderPreOrderTraversal()
		{
			PreOrderTraversal preOrderTraversalTree = new PreOrderTraversal();

			preOrderTraversalTree.binaryTree.root = new Node(1);
			preOrderTraversalTree.binaryTree.root.left = new Node(2);
			preOrderTraversalTree.binaryTree.root.right = new Node(3);
			preOrderTraversalTree.binaryTree.root.left.left = new Node(4);
			preOrderTraversalTree.binaryTree.root.left.right = new Node(5);

			Console.WriteLine("Pre order traversal of binary tree using Recursion is ");
			preOrderTraversalTree.RecursivePreOrderTraversal(preOrderTraversalTree.binaryTree.root);
			Console.WriteLine("");
			Console.WriteLine("Pre order traversal of binary tree using Iterative Approach is ");
			preOrderTraversalTree.IterativePreOrderTraversalUsingStack();
		}
	}
}
