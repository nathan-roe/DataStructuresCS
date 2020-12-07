using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stacks newStack = new Stacks();
            newStack.Display();
            newStack.Add(1);
            newStack.Add(2);
            newStack.Add(3);
            newStack.Add(4);
            newStack.Add(5);
            newStack.Display();
            newStack.Pop();
            newStack.Display();
        }
    }
}
