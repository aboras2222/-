using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, H, S, G, R, V, D, Q, M, X, N,U ;
            H = 1;    
            G = 2;
            R = 3;
            V = 4;
            D = 5;
            Q = 6;
            M = 7;
            X = 8;
            N = 9;
            U = 10;
            Console.WriteLine("Number 1");
            for (F = 1; F <= 10; F++) //*1
            {
                S = F * H;
                Console.WriteLine("1*" + F + "=" + S);
            }
            Console.WriteLine("Number 2");
            for (F = 1; F <= 10; F++) //*2
            {
                S = F * G;
                Console.WriteLine("2*"+F+"=" + S);
            }
            Console.WriteLine("Number 3");
            for (F = 1; F <= 10; F++) //*3
            {
                S = F * R;
                Console.WriteLine("3*" + F + "=" + S);
            }
            Console.WriteLine("Number 4");
            for (F = 1; F <= 10; F++) //*4
            {
                S = F * V;
                Console.WriteLine("4*" + F + "=" + S);
            }
            Console.WriteLine("Number 5");
            for (F = 1; F <= 10; F++) //*5
            {
                S = F * D;
                Console.WriteLine("5*" + F + "=" + S);
            }
            Console.WriteLine("Number 6");
            for (F = 1; F <= 10; F++) //*6
            {
                S = F * Q;
                Console.WriteLine("6*" + F + "=" + S);
            }
            Console.WriteLine("Number 7");
            for (F = 1; F <= 10; F++) //*7
            {
                S = F * M;
                Console.WriteLine("7*" + F + "=" + S);
            }
            Console.WriteLine("Number 8");
            for (F = 1; F <= 10; F++) //*8
            {
                S = F * X;
                Console.WriteLine("8*" + F + "=" + S);
            }
            Console.WriteLine("Number 9");
            for (F = 1; F <= 10; F++) //*9
            {
                S = F * N;

                Console.WriteLine("9*" + F + "=" + S);
            }
            Console.WriteLine("Number 10");
            for (F = 1; F <= 10; F++) //*10
            {
                S = F * U;
                Console.WriteLine("10*" + F + "=" + S);
            }

            Console.ReadKey();
            





            
        }
    }
}
