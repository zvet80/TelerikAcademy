namespace _01.TreeTraversal
{
    using System;
    using System.Collections.Generic;

    public class TreeNode<T>
    {
        public TreeNode()
        {
            this.Children = new List<TreeNode<T>>();
        }

        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.Value = value;
            this.Children = new List<TreeNode<T>>();
        }

        public T Value { get; set; }

        public bool HasParent { get; set; }

        public List<TreeNode<T>> Children { get; set; }

        public int ChildrenCount
        {
            get
            {
                return this.Children.Count;
            }
        }

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException(
                    "Cannot insert null value!");
            }

            if (child.HasParent)
            {
                throw new ArgumentException(
                    "The node already has a parent!");
            }

            child.HasParent = true;
            this.Children.Add(child);
        }

        public TreeNode<T> GetChild(int index)
        {
            return this.Children[index];
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
