using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
	public class LevelOrderSpiralTraversal
	{
		BinaryTree binaryTree = new BinaryTree();

		public void TraverseSpirallyAndPrintEachLevelInNewLine()
		{
			if (binaryTree.root == null)
			{
				return;
			}

			Node currentNode = binaryTree.root;
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(currentNode);
			int levelNumber = 1;
			bool isLTR = false;
			while (queue.Count > 0)
			{
				int elementsInLevel = queue.Count;
				Console.WriteLine("");
				Console.WriteLine($"Printing Level {levelNumber} data ");
				while (elementsInLevel > 0)
				{
					currentNode = queue.Dequeue();
					Console.Write(currentNode.data + " ");
					elementsInLevel--;
					if (isLTR)
					{
						if (currentNode.left != null)
						{
							queue.Enqueue(currentNode.left);
						}
						if (currentNode.right != null)
						{
							queue.Enqueue(currentNode.right);
						}
					}
					else
					{
						if (currentNode.right != null)
						{
							queue.Enqueue(currentNode.right);
						}
						if (currentNode.left != null)
						{
							queue.Enqueue(currentNode.left);
						}
					}
				}
				isLTR = !isLTR;
				levelNumber++;
			}
		}


		public static void PerformLevelOrderSpiralTraversal()
		{
			LevelOrderSpiralTraversal levelOrderSpiralTree = new LevelOrderSpiralTraversal();

			levelOrderSpiralTree.binaryTree.root = new Node(1);
			levelOrderSpiralTree.binaryTree.root.left = new Node(2);
			levelOrderSpiralTree.binaryTree.root.right = new Node(3);
			levelOrderSpiralTree.binaryTree.root.left.left = new Node(4);
			levelOrderSpiralTree.binaryTree.root.left.right = new Node(5);

			Console.WriteLine("Level order spiral traversal of binary tree (Each level data in seperate lines) ");
			levelOrderSpiralTree.TraverseSpirallyAndPrintEachLevelInNewLine();
		}
	}
}