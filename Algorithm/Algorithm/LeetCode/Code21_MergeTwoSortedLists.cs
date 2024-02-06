using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.LeetCode
{
    public class Code21_MergeTwoSortedLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        #region 一般寫法
        //public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        //{
        //    ListNode reuslt = new ListNode();
        //    ListNode current = reuslt;

        //    while (l1 != null && l2 != null)
        //    {
        //        if (l1.val < l2.val)
        //        {
        //            current.next = l1;
        //            l1 = l1.next;
        //        }
        //        else
        //        {
        //            current.next = l2;
        //            l2 = l2.next;
        //        }
        //        current = current.next;
        //    }

        //    if (l1 != null)
        //    {
        //        current.next = l1;
        //    }
        //    else
        //    {
        //        current.next = l2;
        //    }

        //    return reuslt.next;
        //}
        #endregion
        #region 遞歸
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            if (l1.val > l2.val)
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
            else
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }

        }
        #endregion
    }
}
