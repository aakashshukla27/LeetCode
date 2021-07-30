using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ReverseKGroups
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            for (int i = 0; i < k; i++)
            {

            }
            ListNode remaining = head.next.next;

            ListNode newhead = head.next;

            head.next.next = head;

            head.next = ReverseKGroup(remaining, k);

            return newhead;
        }
    }
}
