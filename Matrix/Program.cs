using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Matrix mattTheMatrix = new Matrix(5, 5);
            mattTheMatrix.Print();
        }
    }
}
