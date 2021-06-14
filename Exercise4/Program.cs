using System;

namespace Exercise4
{
    class A
    {
        static int n =1;
        public void f() {
            n++;
        }
        public void Report() {
            Console.WriteLine(n.ToString());
        }
    }
    class Mainclass
    {
        [STAThread]
        static void Main (string[] args) {
            A x = new A(), Y = new A();
            x.f();
            x.Report();
            Y.f();
            Y.Report();
        }
    }
}
