namespace StudentClass.Models
{
    using System;

    public struct BinaryTree<T> : ICloneable
        where T : IComparable
    {
        private NodeTree<T> root;

        private BinaryTree(NodeTree<T> root)
        {
            this.root = new NodeTree<T>(root);
        }

        public NodeTree<T> Root
        {
            get
            {
                return this.root;
            }
            private set
            {
                this.root = value;
            }
        }

        public bool IsEmpty()
        {
            return this.root == null;
        }

        public void Add(T data)
        {
            var forAdd = new NodeTree<T>(data);
            if (this.IsEmpty())
            {
                this.root = forAdd;
            }
            else
            {
                root.AddNodeHere(forAdd);
            }
        }

        public bool Search(T data)
        {
            var searched = new NodeTree<T>(data);
            if (this.IsEmpty())
            {
                return false;
            }
            else
            {
                return this.root.SearchNodeHere(searched);
            }
        }

        public void Remove(T data)
        {
            var forRemove = new NodeTree<T>(data);
            if (this.IsEmpty())
            {
                return;
            }
            else
            {
                if (this.root.Equals(forRemove))
                {
                    this.Root = this.Root.RemoveThisNode();
                }
                else
                {
                    this.Root.FindAndRemove(forRemove);
                }
            }
        }

        public override string ToString()
        {
            return this.Root?.ToString();
        }

        public BinaryTree<T> Clone()
        {
            return new BinaryTree<T>(this.Root);
        }

        object ICloneable.Clone()
        {
            return (object)this.Clone();
        }
    }
}