using System;
namespace Stack
{
    public class Stacks
    {
        public SNode Top;
        public Stacks()
        {
            Top = null;
        }
        public void Add(int val)
        {
            if(Top == null)
            {
                Top = new SNode(val);
            }
            else
            {
                SNode runner = Top;
                while(runner.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = new SNode(val);
            }
            
        }
        public void Display()
        {
            SNode runner = Top;
            while(runner != null)
            {
                System.Console.WriteLine(runner.Value);
                runner = runner.Next;
            }
        }
        public int Pop()
        {
            SNode runner = Top;
            while(runner.Next.Next != null)
            {
                runner = runner.Next;
            }
            SNode retVal = runner.Next;
            runner.Next = runner.Next.Next;
            return retVal.Value;
        }

    }
}