using System;
using System.Collections.Generic;


namespace Scenario_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Queue<int> q1 = generateSortedQueue(r, 5);
            printQueue(q1);
            Queue<int> q2 = generateSortedQueue(r, 3);
            printQueue(q2);

            while(q1.Count > 0 && q2.Count > 0)
            {
                int n1 = q1.Peek();
                int n2 = q2.Peek();
                if(n1 < n2)
                {
                    Console.Write("{0} ", n1);
                    q1.Dequeue();
                } else
                {
                    Console.Write("{0} ", n2);
                    q2.Dequeue();
                }
            }

            if(q1.Count > 0)
            {
                printQueue(q1);
            }

            if (q2.Count > 0)
            {
                printQueue(q2);
            }

        }

        static Queue<int> generateSortedQueue(Random r, int n)
        {
            Queue<int> q = new Queue<int>();
            int start, end;
            for(int i = 0; i < n; i++)
            {
                start = i * 100;
                end = start + 100;
                q.Enqueue(r.Next(start, end));
            }
            return q;
        }

        static void printQueue(Queue<int> q)
        {
            foreach(int i in q)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine(); // newline
        }
    }
}
