using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithm
{
    //建立樹節點
    public class Node
    {
        //節點的值
        public int Value { get; set; }

        //左
        public Node? Left { get; set; }

        //右
        public Node? Right { get; set; }

        public Node(int node)
        {
            Value = node;
            Left = null;
            Right = null;
        }
    }

    //二元樹
    public class BTree
    {
        public Node? Root { get; set; }

        public BTree()
        {
            Root = null;
        }

        //廣度優先搜尋
        private void BreadthFirstSearch(Node node)
        {
            if (node == null)
            {
                return;
            }
            // 隊列，FIFO
            Queue<Node> queue = new Queue<Node>();
            // 壓棧
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                //取第一個
                Node cur = queue.Dequeue();
                Console.WriteLine(cur.Value);
                //先壓左在壓右
                if (cur.Left != null)
                {
                    queue.Enqueue(cur.Left);
                }
                if (cur.Right != null)
                {
                    queue.Enqueue(cur.Right);
                }
            }
        }

        public void BFS()
        {
            BreadthFirstSearch(Root);
        }

        public void GetMaxWidth(Node head)
        {
            if (head == null)
            {
                return;
            }

            Dictionary<Node, int> dic = new Dictionary<Node, int>();
            dic.Add(head, 1);
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(head);
            int maxWidth = 0;
            int curLevel = 1;
            int nodesCount = 0;

            while (queue.Count > 0)
            {
                Node cur = queue.Dequeue();
                int nodeLevel = dic[cur];

                if (curLevel == nodeLevel)
                {
                    nodesCount++;
                }
                else
                {
                    maxWidth = Math.Max(maxWidth, nodesCount);
                    curLevel++;
                    nodesCount = 1;
                }

                if (cur.Left != null)
                {
                    queue.Enqueue(cur.Left);
                    dic.Add(cur.Left, nodeLevel + 1);
                }
                if (cur.Right != null)
                {
                    queue.Enqueue(cur.Right);
                    dic.Add(cur.Right, nodeLevel + 1);
                }
            }

            maxWidth = Math.Max(maxWidth, nodesCount);
            Console.WriteLine($"MaxWidth is {maxWidth}");
        }

    }
}
