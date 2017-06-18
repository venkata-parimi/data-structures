using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
	class RecursiveLevelOrderTraversal
	{
		public BinaryTree bTree = new BinaryTree();

		/* function to print level order traversal of tree*/
		public	void printLevelOrder(bool newLine)
		{
			int height = Utilities.CalculateHeightOfTree(bTree.root);
			for (int i = 1; i <= height; i++)
			{
				if(newLine)
				{
					Console.WriteLine("");
					Console.WriteLine($"Printing Level {i}");
				}
				printGivenLevel(bTree.root, i);
			}
		}

		/* Print nodes at the given level */
	private	void printGivenLevel(Node root, int level)
		{
			if (root == null)
			{
				return;
			}
			if (level == 1)
			{
				Console.Write(root.data + " ");
			}
			else if (level > 1)
			{
				printGivenLevel(root.left, level - 1);
				printGivenLevel(root.right, level - 1);
			}
		}

		/* Driver program to test above functions */
		public static void PerformRecursiveLevelOrderTraversal()
		{
			RecursiveLevelOrderTraversal levelOrderTree = new RecursiveLevelOrderTraversal();

			levelOrderTree.bTree.root = new Node(1);
			levelOrderTree.bTree.root.left = new Node(2);
			levelOrderTree.bTree.root.right = new Node(3);
			levelOrderTree.bTree.root.left.left = new Node(4);
			levelOrderTree.bTree.root.left.right = new Node(5);

			Console.WriteLine("Level order traversal of binary tree is ");
			levelOrderTree.printLevelOrder(newLine: false);
			Console.WriteLine("");
			Console.WriteLine("Level order traversal of binary tree (Each level data in seerate lines) ");
			levelOrderTree.printLevelOrder(newLine: true);
		}
	}
}
