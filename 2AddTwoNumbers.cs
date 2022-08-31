public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if (l1 == null) return l2;
            if (l2 == null) return l1;
            int tempSum = l1.val + l2.val;
            if (tempSum < 10)
            {
                ListNode result = new ListNode(tempSum);
                result.next = AddTwoNumbers(l1.next, l2.next);
                return result;
            }
            else
            {
                tempSum -= 10;
                ListNode result = new ListNode(tempSum);
                result.next = AddTwoNumbers(new ListNode(1), AddTwoNumbers(l1.next, l2.next));
                return result;
            }
 }
