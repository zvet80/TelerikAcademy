namespace _01.TreeTraversal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var tree = CreateTree(ReadConsoleInput());
            var root = GetRootNode(tree);
            Console.WriteLine("Tree root is: {0}", root.Value);
            var leaves = GetAllLeaves(tree);
            Console.WriteLine("Tree leaves are: " + string.Join(",", leaves));
            var middleNodes = GetMiddleNodes(tree);
            Console.WriteLine("Tree middle nodes are: " + string.Join(",", middleNodes));
            int path = FindLongestPath(root);
            Console.WriteLine("Longest path in tree is {0} nodes", path);
        }

        public static int[,] ReadConsoleInput()
        {
            /*Console.WriteLine("Enter number of nodes: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter tree nodes: ");
            int[,] nodesValues = new int[count - 1, 2];

            for (int i = 0; i < count; i++)
            {
                string[] line = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                nodesValues[i, 0] = int.Parse(line[0]);
                nodesValues[i, 1] = int.Parse(line[1]);
            }

            return nodesValues;*/
            return new int[,] { { 2, 4 }, { 3, 2 }, { 5, 0 }, { 3, 5 }, { 5, 6 }, { 5, 1 } };
        }

        public static List<TreeNode<int>> CreateTree(int[,] nodesValues)
        {
            var tree = new List<TreeNode<int>>();

            for (int i = 0; i < nodesValues.GetLength(0); i++)
            {
                int parentValue = nodesValues[i, 0];
                int childValue = nodesValues[i, 1];

                var parentNode = tree.FirstOrDefault(x => x.Value == parentValue);
                var childNode = tree.FirstOrDefault(x => x.Value == childValue);

                if (parentNode == null)
                {
                    parentNode = new TreeNode<int>(parentValue);
                    tree.Add(parentNode);
                }

                if (childNode == null)
                {
                    childNode = new TreeNode<int>(childValue);
                    tree.Add(childNode);
                }

                parentNode.AddChild(childNode);
            }

            return tree;
        }

        public static TreeNode<int> GetRootNode(List<TreeNode<int>> tree)
        {
            TreeNode<int> root = new TreeNode<int>();

            foreach (TreeNode<int> node in tree)
            {
                if (!node.HasParent)
                {
                    root = node;
                }
            }

            return root;
        }

        public static List<TreeNode<int>> GetAllLeaves(List<TreeNode<int>> tree)
        {
            List<TreeNode<int>> leaves = new List<TreeNode<int>>();

            foreach (TreeNode<int> node in tree)
            {
                if (node.ChildrenCount == 0)
                {
                    leaves.Add(node);
                }
            }

            return leaves;
        }

        public static List<TreeNode<int>> GetMiddleNodes(List<TreeNode<int>> tree)
        {
            List<TreeNode<int>> middleNodes = new List<TreeNode<int>>();

            foreach (TreeNode<int> node in tree)
            {
                if (node.HasParent && node.ChildrenCount > 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        public static int FindLongestPath(TreeNode<int> root)
        {
            int maxPath = 0;
            int path = 1;

            foreach (TreeNode<int> child in root.Children)
            {
                path = path + FindLongestPath(child);

                if (maxPath < path)
                {
                    maxPath = path;
                }
            }

            return maxPath;
        }
    }
}
