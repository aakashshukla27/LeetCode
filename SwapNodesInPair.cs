using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class SwapNodesInPair
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode remaining = head.next.next;

            ListNode newhead = head.next;

            head.next.next = head;

            head.next = SwapPairs(remaining);

            return newhead;
        }

       
    }
}
