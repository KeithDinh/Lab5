﻿using System;

namespace Exercise8
{
    abstract class A
    {
        int X;
        public abstract void f (int n);
        private virtual void g(uint n)
        {
            X = n as int;
        }
        public string ToString()
        {
            return X.ToString();
        }
}
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
