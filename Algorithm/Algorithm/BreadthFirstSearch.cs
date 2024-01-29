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

    }
}
