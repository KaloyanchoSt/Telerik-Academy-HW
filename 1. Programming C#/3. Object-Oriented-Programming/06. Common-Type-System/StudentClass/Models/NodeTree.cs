using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass.Models
{
    using System;

    public class NodeTree<T> : IComparable where T : IComparable
    {
        private T data;

        public NodeTree(T data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }

        internal NodeTree(NodeTree<T> forCopy)
        {
            this.Data = forCopy.Data;
            this.Left = forCopy.Left?.DeepCopy();
            this.Right = forCopy.Right?.DeepCopy();
        }

        public T Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }

        public NodeTree<T> Left { get; set; }

        public NodeTree<T> Right { get; set; }

        public void AddNodeHere(NodeTree<T> forAdd)
        {
            if (this.CompareTo(forAdd) == 0)
            {
                throw new ArgumentException("Nodes are equals!");
            }

            if (this.CompareTo(forAdd) < 0)
            {
                if (this.Right == null)
                {
                    this.Right = forAdd;
                }
                else
                {
                    this.Right.AddNodeHere(forAdd);
                }
            }
            else
            {
                if (this.Left == null)
                {
                    this.Left = forAdd;
                }
                else
                {
                    this.Left.AddNodeHere(forAdd);
                }
            }
        }

        public bool SearchNodeHere(NodeTree<T> searched)
        {
            if (this.CompareTo(searched) == 0)
            {
                return true;
            }
            else if (this.CompareTo(searched) < 0)
            {
                if (this.Right == null)
                {
                    return false;
                }

                this.Right.SearchNodeHere(searched);
            }
            else
            {
                if (this.Left == null)
                {
                    return false;
                }

                this.Left.SearchNodeHere(searched);
            }

            return false;
        }

        // need reworking still but working 
        public NodeTree<T> RemoveThisNode()
        {
            if (this.Left == null & this.Right == null)
            {
                return null;
            }
            else if (this.Left == null)
            {
                return this.Right;
            }
            else if (this.Right == null)
            {
                return this.Left;
            }
            else
            {
                T minData = this.Right.FindMin();
                this.Data = minData;
                if (this.Right.Data.Equals(minData))
                {
                    this.Right = this.Right.RemoveThisNode();
                }
                else
                {
                    this.Right.RemoveMin(minData);
                }
                return this;
            }
        }

        private void RemoveMin(T minData)
        {
            if (this.Left.Data.Equals(minData))
            {
                this.Left = this.Left.RemoveThisNode();
            }
            else
            {
                this.Left.RemoveMin(minData);
            }
        }

        private T FindMin()
        {
            if (this.Left == null)
            {
                return this.Data;
            }
            else
            {
                return this.Left.FindMin();
            }
        }

        public void FindAndRemove(NodeTree<T> forRemove)
        {
            if (this.CompareTo(forRemove) < 0)
            {
                if (this.Right == null)
                {
                    return;
                }

                if (this.Right.CompareTo(forRemove) == 0)
                {
                    this.Right = this.Right.RemoveThisNode();
                }
                else
                {
                    this.Right.FindAndRemove(forRemove);
                }
            }
            else
            {
                if (this.Left == null)
                {
                    return;
                }

                if (this.Left.CompareTo(forRemove) == 0)
                {
                    this.Left = this.Left.RemoveThisNode();
                }
                else
                {
                    this.Left.FindAndRemove(forRemove);
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{1} {0} {2}",
                this.Data.ToString(),
                this.Left?.ToString(),
                this.Right?.ToString()).Trim();
        }

        public override bool Equals(object node)
        {
            if (!(node is NodeTree<T>))
            {
                return false;
            }

            var other = node as NodeTree<T>;
            return this.Data.Equals(other.Data);
        }

        public override int GetHashCode()
        {
            return this.Data.GetHashCode();
        }

        public int CompareTo(object node)
        {
            if (!(node is NodeTree<T>))
            {
                throw new ArgumentException("Object is not a Node<T>!");
            }

            var other = node as NodeTree<T>;
            return this.CompareTo(other);
        }

        public int CompareTo(NodeTree<T> other)
        {
            return this.Data.CompareTo(other.Data);
        }

        public static bool operator ==(NodeTree<T> first, NodeTree<T> second)
        {
            if (ReferenceEquals(first, null) && ReferenceEquals(second, null))
            {
                return true;
            }

            if (ReferenceEquals(first, null) || ReferenceEquals(second, null))
            {
                return false;
            }

            return first.Equals(second);
        }

        public static bool operator !=(NodeTree<T> first, NodeTree<T> second)
        {
            return !(first == second);
        }

        public NodeTree<T> DeepCopy()
        {
            return new NodeTree<T>(this);
        }

        // carefully ! 
        public static T operator +(NodeTree<T> first, NodeTree<T> second)
        {
            return second.Data;

        }
    }
}