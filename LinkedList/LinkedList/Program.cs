using System;
using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node() { Value = 2 };
            Node second = new Node() { Value = 3 };
            first.Next = second;
            Node third = new Node() { Value = 3 };
            second.Next = third;
            Node fourth = new Node() { Value = 5 };
            third.Next = fourth;
            PrintoutLinkedList(first);
            Node nd=DeleteDuplicate(first);
            Console.WriteLine(nd);
            PrintoutLinkedList(nd);
            Console.WriteLine("hello");
            //string s = "hello";
            //char[] charArray = s.ToCharArray();
            //Array.Reverse(charArray);
            //string srev = new(charArray);
            //Console.WriteLine(srev);
            //for (int i = 0; i < s.Length-1;i++)
            //{
            //    Console.WriteLine(s[i + 1] - s[i]);
            //}
            string s = "aabbc";
            Dictionary<char,int> dict= new Dictionary<char, int>();
            foreach (char ch in s)
            {
               if(dict.ContainsKey(ch))
                    dict[ch]+= 1;
                else
                    dict[ch] = 1;
            }
            foreach (KeyValuePair<char,int> kv in dict)
            {
                Console.WriteLine($"Key: {kv.Key}, Value: {kv.Value}");
            }
            foreach(char key in dict.Keys)
            {
                Console.WriteLine(key);
            }
        }
        private static void PrintoutLinkedList(Node node)
        {
            while(node!=null)
            {
                Console.WriteLine($"Node value {node.Value}");
                node = node.Next;
            }
        }
        public static Node DeleteDuplicate(Node node)
        {
            List<Node> lstnode = new List<Node>();
            while (node!=null)
            {
                if (node.Next != null && node.Value == node.Next.Value)
                {
                    
                    node = node.Next.Next;
                    lstnode.Add(node);
                    Console.WriteLine("removed");
                }
                else
                {
                    
                    node = node.Next;
                    lstnode.Add(node);
                }
            }
            return lstnode[0];
        }
    }
}
