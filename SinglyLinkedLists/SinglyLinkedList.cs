namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        public SllNode Head;
        public SinglyLinkedList() 
        {
            Head = null;
        }
        public int Remove()
        {
            SllNode runner = Head;
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
            SllNode runner = Head;
            while(runner.Next != null)
            {
                System.Console.WriteLine(runner.Value);
                runner = runner.Next;
            }
            System.Console.WriteLine(runner.Value);
        }
        public SllNode Find(int val)
        {
            SllNode runner = Head;
            while(runner.Value != val)
            {
                runner = runner.Next;
            }
            return runner;
        }
        public SllNode RemoveAtN(int idx)
        {
            SllNode runner = Head;
            for(int i=0;i<idx-1;i++)
            {
                runner = runner.Next;
            }
            SllNode retVal = runner.Next;
            runner.Next = runner.Next.Next;
            return retVal;
        }
        public void Add(int value) 
        {
            SllNode newNode = new SllNode(value);
            if(Head == null) 
            {
                Head = newNode;
            } 
            else
            {
                SllNode runner = Head;
                while(runner.Next != null) {
                    runner = runner.Next;
                }
                runner.Next = newNode;
            }
        }    
    }
}