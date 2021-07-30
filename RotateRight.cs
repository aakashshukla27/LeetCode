using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class RotateRight
    {
        public ListNode RotateRightSolution(ListNode head, int k)
        {
            ListNode temp = head;
            int count = 0;
            while(temp != null)
            {
                temp = temp.next;
                count++;
            }
            temp = head;
            ListNode p = new ListNode();
            for(int i = 0; i<count - k; i++)
            {
                p = temp;
                temp = temp.next;
            }
            ListNode p1 = new ListNode();
            p1 = temp;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = head;
            p.next = null;
            return p1;

        }

        private ListNode AddAtBeginning(ListNode head, ListNode p)
        {
            p.next = head;
            head = p;
            return head;
        }



    }
}
