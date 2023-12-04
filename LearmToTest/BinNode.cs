using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTestMhat
{
    internal class BinNode<T>
    {
        T value;
        BinNode<T> right, left;

        public BinNode(T value, BinNode<T> right, BinNode<T> left)
        {
            this.value = value;
            this.right = right;
            this.left = left;
        }
         public BinNode(T value)
        {
            this.value = value;
        }
        public T GetValue() => value;
        public BinNode<T> GetRight() => right;
        public BinNode<T> GetLeft() => left;
        public void SetValue(T value)=>this.value= value;
        public void SetRight(BinNode<T> right) => this.right = right;
        public void SetLeft(BinNode<T> l) => this.left = l;
        public bool HasRight() => right != null;
        public bool HasLeft() => left != null;


    }
}
