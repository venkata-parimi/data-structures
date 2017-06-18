using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
	class MirrorTree
	{
		public BinaryTree binaryTree = new BinaryTree();
		public BinaryTree mirrorBinaryTree = new BinaryTree();

		public void CreateMirrorTree(Node mainTreeNode, Node mirrorTreeNode)
		{
			if (mainTreeNode == null)
			{
				mirrorTreeNode = null;
				return;
			}
			mirrorTreeNode = new Node(mainTreeNode.data);
			CreateMirrorTree(mainTreeNode.left, mirrorTreeNode.right);
			CreateMirrorTree(mainTreeNode.right, mirrorTreeNode.left);
		}

		
		public static void PerformMirrorImagingOfTree()
		{
			MirrorTree mirrorTree = new MirrorTree();

			mirrorTree.binaryTree.root = new Node(1);
			mirrorTree.binaryTree.root.left = new Node(2);
			mirrorTree.binaryTree.root.right = new Node(3);
			mirrorTree.binaryTree.root.left.left = new Node(4);
			mirrorTree.binaryTree.root.left.right = new Node(5);

			Console.WriteLine("Creating the mirror image of Binary tree ");
			mirrorTree.CreateMirrorTree(mirrorTree.binaryTree.root, mirrorTree.mirrorBinaryTree.root);
			Console.WriteLine("Printing the main Binary tree ");
			Console.WriteLine("");
			Utilities.PrintInOrderTraversal(mirrorTree.binaryTree.root);
			Console.WriteLine("");
			Console.WriteLine("Printing the mirror image of Binary tree ");
			Utilities.PrintInOrderTraversal(mirrorTree.binaryTree.root);
		}
	}
}
