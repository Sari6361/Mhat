using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTestMhat
{
    public class Queue<T>
    {
        T value;
        Node<T> head, tail;
        public Queue()
        {

        }
        public void Insert(T value)
        {
            if (head == null)
            {
                tail=head = new Node<T>(value);
              
            }
            else
            {
                tail.SetNext(new Node<T>(value));
                tail = tail.GetNext();
            }
        }
        public T Remove()
        {
            T temp = head.GetValue();
            head = head.GetNext();
            return temp;

        }
        public T Head()=>head.GetValue();//הצצה לראש 
        public bool IsEmpty() => head == null;
        public override string ToString()
        {
            string str = "";
            Node<T> node = head;
            while (node != null)
            {
                str += node.ToString()+" ";
                node = node.GetNext();
            }
            return str + "\n";
        }
    }
}
