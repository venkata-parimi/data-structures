using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
	class PostOrderTraversal
	{
		public BinaryTree binaryTree = new BinaryTree();

		public void RecursivePostOrderTraversal(Node node)
		{
			if (node == null)
			{
				return;
			}
			RecursivePostOrderTraversal(node.left);
			RecursivePostOrderTraversal(node.right);
			Console.WriteLine(node.data);
		}

		public void IterativePostOrderTraversalUsingStack()
		{
			if (binaryTree.root == null)
			{
				return;
			}

			Stack<Node> stack = new Stack<Node>();
			Node currentNode = binaryTree.root;
			Node lastPoppedNode = binaryTree.root;
			stack.Push(currentNode);
			while (currentNode.left != null)
			{
				currentNode = currentNode.left;
				stack.Push(currentNode);
			}

			while (stack.Count > 0)
			{
				currentNode = stack.Peek();
				if (currentNode.right == null)
				{
					currentNode = stack.Pop();
					lastPoppedNode = currentNode;
					Console.WriteLine(currentNode.data);
				}
				else if (currentNode.right != null)
				{
					if (currentNode.right != lastPoppedNode)
					{
						currentNode = currentNode.right;
						stack.Push(currentNode);
						while (currentNode.left != null)
						{
							currentNode = currentNode.left;
							stack.Push(currentNode);
						}
					}
					else
					{
						currentNode = stack.Pop();
						Console.WriteLine(currentNode.data);
					}
				}
			}
		}

		public static void PerformPostOrderPostOrderTraversal()
		{
			PostOrderTraversal postOrderTraversalTree = new PostOrderTraversal();

			postOrderTraversalTree.binaryTree.root = new Node(1);
			postOrderTraversalTree.binaryTree.root.left = new Node(2);
			postOrderTraversalTree.binaryTree.root.right = new Node(3);
			postOrderTraversalTree.binaryTree.root.left.left = new Node(4);
			postOrderTraversalTree.binaryTree.root.left.right = new Node(5);

			Console.WriteLine("Post order traversal of binary tree using Recursion is ");
			postOrderTraversalTree.RecursivePostOrderTraversal(postOrderTraversalTree.binaryTree.root);
			Console.WriteLine("");
			Console.WriteLine("Post order traversal of binary tree using Iterative Approach is ");
			postOrderTraversalTree.IterativePostOrderTraversalUsingStack();
		}
	}
}
