namespace DoublyLinkedLists
{
    public class DllNode
    {
        public int Value;
        public DllNode Next;
        public DllNode Prev;
        public DllNode(int value) 
        {
            Value = value;
            Next = null;
            Prev = null;
        }
    }
}