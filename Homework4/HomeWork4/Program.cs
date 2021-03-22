using System;

namespace HomeWork4
{
    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            for(Node<T> p = head; p != null; p = p.Next)
            {
                 action(p.Data);
            }     
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> List = new GenericList<int>();
            for(int i = 0; i < 10; i++)
            {
                List.Add(i + 1);
            }

            int max = int.MinValue, min = int.MaxValue, sum = 0, cnt = 0;
            List.ForEach((m) =>
            {
                if (max < m)
                    max = m;
                if (min > m)
                    min = m;
                sum += m;
                cnt++;
                Console.WriteLine(m);
            });
            Console.WriteLine($"最大值:{max} ,最小值: {min} ,平均值: {1.0 * sum / cnt }");
        }
    }

}
