using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
	class TreeHeight
	{
		public BinaryTree binaryTree = new BinaryTree();

		public int CalculateTreeHeight(Node node)
		{
			if (node == null)
			{
				return 0;
			}
			int leftTreeHeight = CalculateTreeHeight(node.left);
			int rightTreeHeight = CalculateTreeHeight(node.right);
			return leftTreeHeight > rightTreeHeight ? leftTreeHeight + 1 : rightTreeHeight + 1; ;
		}


		public static void PerformTreeHeightCalculation()
		{
			TreeHeight treeHeight = new TreeHeight();

			treeHeight.binaryTree.root = new Node(1);
			treeHeight.binaryTree.root.left = new Node(2);
			treeHeight.binaryTree.root.right = new Node(3);
			treeHeight.binaryTree.root.left.left = new Node(4);
			treeHeight.binaryTree.root.left.right = new Node(5);
			treeHeight.binaryTree.root.left.right.left = new Node(7);

			Console.WriteLine("Height of binary tree using Recursion is ");
			int result = treeHeight.CalculateTreeHeight(treeHeight.binaryTree.root);
			Console.WriteLine("");
			Console.WriteLine(result);
		}
	}
}
