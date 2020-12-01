using System;

namespace SinglyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList sl = new SinglyLinkedList();
            sl.Add(1);
            sl.Add(2);
            sl.Add(3);
            sl.Add(4);
            sl.PrintVals();
            sl.Find(2);
            sl.RemoveAtN(2);
            sl.PrintVals();
        }
    }
}
