namespace SkipList
{
    public class DllNode
    {
        public int Value;
        public DllNode Next;
        public DllNode Prev;
        public ExpressNode Top;
        public DllNode(int value) 
        {
            Value = value;
            Next = null;
            Prev = null;
            Top = null;
        }
    }
}