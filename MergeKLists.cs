using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    class MergeKLists
    {
        public ListNode MergeKListsSolution(ListNode[] lists)
        {
            
            if (lists.Length == 0)
                return null;

            MinPQ pq = new MinPQ(0);
            int count = 0;

            for (int i = 0; i < lists.Length; i++)
            {
                while(lists[i] != null)
                {
                    pq.Insert(lists[i].val);
                    lists[i] = lists[i].next;
                    count++;
                }
            }

            ListNode p = new ListNode(0);
            ListNode p2 = p;

            for(int i=1; i<= count; i++)
            {
                p2.next = new ListNode(pq.delMin());
                p2 = p2.next;
            }


            return p.next;

        }
        class MinPQ
        {
            private int[] pq;
            private int n;

            public MinPQ(int capacity)
            {
                pq = new int[capacity + 1];
                n = 0;
            }

            public int Size() => n;

            public bool IsEmpty() => n == 0;

            private void Resize(int capacity)
            {

                int[] temp = new int[capacity];
                for (int i = 1; i <= n; i++)
                {
                    temp[i] = pq[i];
                }
                pq = temp;
            }


            public void Insert(int x)
            {
                // double size of array if necessary
                if (n == pq.Length - 1) Resize(2 * pq.Length);

                pq[++n] = x;
                Swim(n);
            }

            private void Swim(int k)
            {
                while (k > 1 && greater(k / 2, k))
                {
                    Exch(k, k / 2);
                    k /= 2;
                }
            }

            private void Sink(int k)
            {
                while (2 * k <= n)
                {
                    int j = 2 * k;
                    if (j < n && greater(j, j + 1)) j++;
                    if (!greater(k, j)) break;
                    Exch(k, j);
                    k = j;
                }
            }

            private bool greater(int i, int j) => (pq[i]).CompareTo(pq[j]) > 0;


            private void Exch(int i, int j)
            {
                int swap = pq[i];
                pq[i] = pq[j];
                pq[j] = swap;
            }

            public int delMin()
            {
                if (IsEmpty()) throw new Exception("Priority queue underflow");
                int min = pq[1];
                Exch(1, n--);
                Sink(1);
                if ((n > 0) && (n == (pq.Length - 1) / 4)) Resize(pq.Length / 2);
                return min;
            }
        }
    }

    

    
}
