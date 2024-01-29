using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Algorithm
{
    //樹節點
    public class TreeNode
    {
        public int? Value { get; set; }
        public TreeNode? Right { get; set; }
        public TreeNode? Left { get; set; }

        /// <summary>
        /// Node : BinaryTree Node
        /// </summary>
        /// <param name="value"></param>

        //Init 並 定義預設null
        public TreeNode(int? value) 
        {
            Value = value;
            Right = null;
            Left = null;
        }
    }
    public class BinaryTree
    {
        public TreeNode? Root { get; set; }
        public BinaryTree() 
        {
            Root = null;
        }

        //遍歷每個節點，依序從左至右，到節點就印出來
        private void PreorderTraversal(TreeNode node)
        {
            if (node != null) 
            {
                Console.WriteLine(node.Value + " ");
                PreorderTraversal(node.Left);
                PreorderTraversal(node.Right);
            }
        }

        private void InorderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InorderTraversal(node.Left);
                Console.WriteLine(node.Value + " ");
                InorderTraversal(node.Right);
            }
        }

        private void ProrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                ProrderTraversal(node.Left);
                ProrderTraversal(node.Right);
                Console.WriteLine(node.Value + " ");
            }
        }

        //前序
        public void Preorder()
        {
            PreorderTraversal(Root);
        }

        //中序
        public void Inorder()
        {
            InorderTraversal(Root);
        }

        //後序
        public void Prorder()
        {
            ProrderTraversal(Root);
        }

        public void Print()
        {
            if (Root.Value == null)
            {
                Console.WriteLine("此樹沒有節點");
            }
            else
            {
                Console.WriteLine($"前序是 : ");
                Preorder();
                Console.WriteLine($"中序是 : ");
                Inorder();
                Console.WriteLine($"後序是 : ");
                Prorder();
            }
        }
    }
}
