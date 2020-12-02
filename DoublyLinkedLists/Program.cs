using System;

namespace DoublyLinkedLists
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
            dl.PrintVals();
            // dl.Find(2);
            // dl.RemoveAtN(2);
            // dl.PrintVals();
            dl.Reverse();
            dl.PrintVals();
        }
    }
}
