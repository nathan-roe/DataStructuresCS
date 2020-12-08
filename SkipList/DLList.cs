namespace SkipList
{
    public class DLList
    {
        public DllNode Head;
        public DLList() 
        {
            Head = null;
        }
        public int Remove()
        {
            DllNode runner = Head;
            while(runner.Next.Next != null)
            {
                runner = runner.Next;
            }
            int retVal = runner.Value;
            runner.Next = null;
            return retVal;
        }
        public void PrintVals()
        {
            DllNode runner = Head;
            while(runner.Next != null)
            {
                if(runner.Top != null)
                {
                    System.Console.WriteLine($"{runner.Value} -> {runner.Top.DNode.Value}");
                }
                else
                {
                    System.Console.WriteLine($"{runner.Value}    |");
                }
                runner = runner.Next;
            }
            if(runner.Top != null)
            {
                System.Console.WriteLine($"{runner.Value} -> {runner.Top.DNode.Value}");
            }
            else
            {
                System.Console.WriteLine($"{runner.Value}    |");
            }
        }
        public DllNode Find(int val)
        {
            DllNode runner = Head;
            while(runner.Value != val)
            {
                runner = runner.Next;
            }
            return runner;
        }
        public DllNode RemoveAtN(int idx)
        {
            DllNode runner = Head;
            for(int i=0;i<idx-1;i++)
            {
                runner = runner.Next;
            }
            DllNode retVal = runner.Next;
            runner.Next = runner.Next.Next;
            return retVal;
        }
        public void Add(int value) 
        {
            DllNode newNode = new DllNode(value);
            if(Head == null) 
            {
                Head = newNode;
                ExpressNode eNode = new ExpressNode(Head);
                Head.Top = eNode;
            } 
            else
            {
                DllNode runner = Head;
                DllNode prevRunner = Head;
                DllNode found = Head;
                int count = 0;
                while(runner.Next != null) {
                    if(count >= 5)
                    {
                        ExpressNode newENode = new ExpressNode(runner);
                        runner.Top = newENode;
                        count = 1;
                    }
                    if(count != 0)
                    {
                        prevRunner = prevRunner.Next;
                    }
                    runner = runner.Next;
                    count++;
                }
                prevRunner = newNode.Prev;
                runner.Next = newNode;
            }
        }  
        public void Reverse()
        {
            DllNode runner = Head;
            while(runner.Next != null)
            {
                runner = runner.Next;
            }
            DllNode temp = runner.Prev;
            runner.Prev = runner.Next;
            runner.Next = temp;
        }  
    }
}