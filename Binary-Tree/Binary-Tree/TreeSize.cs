using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
	class TreeSize
	{
		public BinaryTree binaryTree = new BinaryTree();

		public int CalculateTreeSize(Node node)
		{
			if (node == null)
			{
				return 0;
			}
			int leftTreeSize = CalculateTreeSize(node.left);
			int rightTreeSize = CalculateTreeSize(node.right);
			return leftTreeSize + rightTreeSize + 1;
		}

		
		public static void PerformCalculationOfTreeSize()
		{
			TreeSize treeSize = new TreeSize();

			treeSize.binaryTree.root = new Node(1);
			treeSize.binaryTree.root.left = new Node(2);
			treeSize.binaryTree.root.right = new Node(3);
			treeSize.binaryTree.root.left.left = new Node(4);
			treeSize.binaryTree.root.left.right = new Node(5);

			Console.WriteLine("Height of binary tree using Recursion is ");
			int result = treeSize.CalculateTreeSize(treeSize.binaryTree.root);
			Console.WriteLine("");
			Console.WriteLine(result);
		}
	}
}
