using System;

namespace SkipList
{
    class Program
    {
        static void Main(string[] args)
        {
            DLList dl = new DLList();
            dl.Add(1);
            dl.Add(2);
            dl.Add(3);
            dl.Add(4);
            dl.Add(5);
            dl.Add(6);
            dl.Add(7);
            dl.Add(8);
            dl.Add(9);
            dl.Add(10);
            dl.Add(11);
            dl.Add(12);
            dl.Add(13);
            dl.Add(14);
            dl.Add(15);
            dl.Add(16);
            dl.Add(17);
            dl.Add(18);
            dl.Add(19);
            dl.Add(20);
            dl.PrintVals();
            // dl.Find(2);
            // dl.RemoveAtN(2);
            // dl.PrintVals();
            // dl.Reverse();
            // dl.PrintVals();
        }
    }
}
