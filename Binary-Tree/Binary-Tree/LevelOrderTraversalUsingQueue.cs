using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
	public class LevelOrderTraversalUsingQueue
	{
		BinaryTree binaryTree = new BinaryTree();
		public void TraversalUsingQueue()
		{
			if (binaryTree.root == null)
			{
				return;
			}

			Node currentNode = binaryTree.root;
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(currentNode);
			while (queue.Count > 0)
			{
				currentNode = queue.Dequeue();
				Console.WriteLine(currentNode.data);
				if (currentNode.left != null)
				{
					queue.Enqueue(currentNode.left);
				}
				if (currentNode.right != null)
				{
					queue.Enqueue(currentNode.right);
				}
			}
		}

		public void TraverseUsingQueueAndPrintEachLevelInNewLine()
		{
			if (binaryTree.root == null)
			{
				return;
			}

			Node currentNode = binaryTree.root;
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(currentNode);
			int levelNumber = 1;
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
					if (currentNode.left != null)
					{
						queue.Enqueue(currentNode.left);
					}
					if (currentNode.right != null)
					{
						queue.Enqueue(currentNode.right);
					}
				}
				levelNumber++;
			}
		}


		public static void PerformLevelOrderTraversalUsingQueue()
		{
			LevelOrderTraversalUsingQueue levelOrderTree = new LevelOrderTraversalUsingQueue();

			levelOrderTree.binaryTree.root = new Node(1);
			levelOrderTree.binaryTree.root.left = new Node(2);
			levelOrderTree.binaryTree.root.right = new Node(3);
			levelOrderTree.binaryTree.root.left.left = new Node(4);
			levelOrderTree.binaryTree.root.left.right = new Node(5);

			Console.WriteLine("Level order traversal of binary tree is ");
			levelOrderTree.TraversalUsingQueue();
			Console.WriteLine("");
			Console.WriteLine("Level order traversal of binary tree (Each level data in seperate lines) ");
			levelOrderTree.TraverseUsingQueueAndPrintEachLevelInNewLine();
		}
	}
}