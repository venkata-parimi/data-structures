using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
	class IdenticalTrees
	{
		public BinaryTree binaryTree = new BinaryTree();

		bool areNodesIdentical = true;
		public bool VerifyIfTressAreIdentical(Node tree1Node, Node tree2Node)
		{
			if (tree1Node == null && tree2Node == null)
			{
				return true;
			}
			if ((tree1Node == null || tree2Node == null) || tree1Node.data != tree2Node.data)
			{
				return false;
			}
			if (areNodesIdentical)
			{
				areNodesIdentical = VerifyIfTressAreIdentical(tree1Node.left, tree2Node.left);
				if (areNodesIdentical)
				{
					areNodesIdentical = VerifyIfTressAreIdentical(tree1Node.right, tree2Node.right);
				}
			}
			return areNodesIdentical;
		}

		
		public static void VerifyIfTressAreIdentical()
		{
			IdenticalTrees identicalTree1 = new IdenticalTrees();

			identicalTree1.binaryTree.root = new Node(1);
			identicalTree1.binaryTree.root.left = new Node(2);
			identicalTree1.binaryTree.root.right = new Node(3);
			identicalTree1.binaryTree.root.left.left = new Node(4);
			identicalTree1.binaryTree.root.left.right = new Node(5);


			IdenticalTrees identicalTree2 = new IdenticalTrees();

			identicalTree2.binaryTree.root = new Node(1);
			identicalTree2.binaryTree.root.left = new Node(2);
			identicalTree2.binaryTree.root.right = new Node(3);
			identicalTree2.binaryTree.root.left.left = new Node(4);
			identicalTree2.binaryTree.root.left.right = new Node(5);

			Console.WriteLine("Height of binary tree using Recursion is ");
			bool result = identicalTree1.VerifyIfTressAreIdentical(identicalTree1.binaryTree.root, identicalTree2.binaryTree.root);
			Console.WriteLine("");
			Console.WriteLine(result);
		}
	}
}
