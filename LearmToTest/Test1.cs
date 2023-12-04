using ForTestMhat;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LearmToTest
{
    public class Test1
    {
        public static void First(Node<int> chain)
        {
            Node<int> ret, head = new Node<int>(chain.GetValue());
            ret = head;
            while (chain is not null)
            {
                head.SetValue(chain.GetValue());
                head.SetNext(new Node<int>(chain.GetValue()));
                chain = chain.GetNext();
                head = head.GetNext().GetNext();
            }
            chain = ret;
        }
        public static void Second(Node<int> chain)
        {
            Node<int> ret, head = new Node<int>(chain.GetValue());
            ret = head;
            while (chain.GetNext() != null)
            {
                head.SetNext(new Node<int>(chain.GetNext().GetValue()));
                chain = chain.GetNext();
            }
            chain.SetNext(head);
            chain = ret;
        }
        public static void Merge(ForTestMhat.Stack<int> s)
        {
            int avg, sum = 0, count = 0;
            ForTestMhat.Stack<int> s2 = new ForTestMhat.Stack<int>();
            ForTestMhat.Stack<int> l = new ForTestMhat.Stack<int>();

            while (s.Top() != null)
            {
                s2.Push(s.Top());
                count++;
                sum += s.Pop();
            }
            avg = sum / count;
            while (s2.Top() != null)
            {
                if (s2.Top() > avg)
                    l.Push(s2.Pop());
                else s.Push(s2.Pop());
            }
            while (l.Top() != null)
                s.Push(l.Pop());
        }

        public static Node<double> AverageList(Node<int> lst)
        {
            Node<double> ret, avg = new Node<double>(0);
            ret = avg;
            int sum = 0, count = 0;
            while (lst != null)
            {
                while (lst != null && lst.GetValue() != -1)
                {
                    sum += lst.GetValue();
                    count++;
                    lst = lst.GetNext();
                }
                avg.SetValue(sum / count);
                count = sum = 0;
                lst = lst.GetNext();
                avg.SetNext(new Node<double>(0));
                avg = avg.GetNext();
            }
            avg = null;
            return ret;
        }

        public static void Print(Node<int> lst)
        {
            Node<double> avg = AverageList(lst);
            int min = 0, count = 0, sum = 0, index = 1;
            while (lst != null)
            {
                while (lst != null && lst.GetValue() != -1)
                {
                    if (min > lst.GetValue())
                        min = lst.GetValue();
                    sum += lst.GetValue();
                    count++;
                    lst = lst.GetNext();
                }
                Console.WriteLine($"{index++} {avg.GetValue()} {(sum - min) / count}");
                sum = count = min = 0;
                avg = avg.GetNext();
                lst = lst.GetNext();
            }
        }

        public static bool EqualsSums(ForTestMhat.Stack<int> s)
        {
            int count = 0, avg = 0;
            ForTestMhat.Stack<int> s2 = new ForTestMhat.Stack<int>();
            avg = s.Top();
            while (s != null)
            {
                s2.Push(s.Pop());
                count++;
            }
            avg += s2.Top();
            for (int i = 0; i < count / 2; i++)
                s.Push(s2.Pop());
            if (count % 2 != 0)
                avg = s2.Pop();
            while (s2.Top() != null)
                if (s2.Pop() + s.Pop() != avg)
                    return false;
            return true;
        }

        public static int NumNodesFollowing(Node<int>node)
        {
            int count=0;
            while(node!=null)
            {
                count++;    
                node = node.GetNext();
            }
            return count;
        }

        public static bool IsSection(Node<int> head)
        {
            while(head!=null)
            {
                if (NumNodesFollowing(head) > head.GetValue())
                    return false;
                head = head.GetNext();
            }
            return true;
        }

        //1
        public static int CountSet(ForTestMhat.Queue<int> q)
        {
            ForTestMhat.Queue<int> q1 =new ForTestMhat.Queue<int> ();
            ForTestMhat.Queue<int> q2 =new ForTestMhat.Queue<int> ();
            int v = 0;
            while(!q.IsEmpty())
            {
                int val = q.Remove();
                q1.Insert(val);
                q2.Insert(val);
            }
            while (!q2.IsEmpty())
                q.Insert(q2.Remove());
            while ((v=q.Remove())!= -q1.Remove()) ;
            int count = 0;
            while (q1.Remove() != v)
                count++;
            return count;
        }

        public static MyNode AddNumber(MyNode list, int val, int position)
        {
            MyNode n = new MyNode(0);
            n = list;
            for (int i = 0; i < position-1; i++)
            {
                n = n.next;
                list = list.next;
            }
            n.next=new MyNode(val);
            n.next.next=list;
            return n;
        }

    }
}
