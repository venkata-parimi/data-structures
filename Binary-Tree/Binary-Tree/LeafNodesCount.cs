using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
	class LeafNodesCount
	{
		public BinaryTree binaryTree = new BinaryTree();

		public int CalculateLeafNodesCount(Node node)
		{
			if (node == null)
			{
				return 0;
			}
			if (node.left == null & node.right == null)
			{
				return 1;
			}
			int leftTreeLeafNodes = CalculateLeafNodesCount(node.left);
			int rightTreeLeafNodes = CalculateLeafNodesCount(node.right);
			return leftTreeLeafNodes + rightTreeLeafNodes;
		}


		public static void PerformLeafNodesInATreeCalculation()
		{
			LeafNodesCount treeHeight = new LeafNodesCount();

			treeHeight.binaryTree.root = new Node(1);
			treeHeight.binaryTree.root.left = new Node(2);
			treeHeight.binaryTree.root.right = new Node(3);
			treeHeight.binaryTree.root.left.left = new Node(4);
			treeHeight.binaryTree.root.left.right = new Node(5);
			treeHeight.binaryTree.root.left.right.left = new Node(7);
			treeHeight.binaryTree.root.left.right.right = new Node(8);
			treeHeight.binaryTree.root.left.left.left = new Node(4);
			treeHeight.binaryTree.root.left.left.right = new Node(4);

			Console.WriteLine("Leaf Nodes count of binary tree is ");
			int result = treeHeight.CalculateLeafNodesCount(treeHeight.binaryTree.root);
			Console.WriteLine("");
			Console.WriteLine(result);
		}
	}
}
