using System;

namespace Exercise9
{
    class A
    {
        public int n;
        public String s;
        public A() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            A[] v = new A[10];
            for(int i=0;i<10; i++)
            {
                v[i] = new A() { n = r.Next(1, 2000), s = $"{r.Next(1, 2000)}---------" };
            }

            Array.Sort(v, delegate (A x, A y) { return x.n.CompareTo(y.n); });

            foreach (var i in v)
            {
                Console.WriteLine($"{i.n} {i.s}");
            }
        }
    }
}
