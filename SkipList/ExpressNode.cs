using System;
namespace SkipList
{
    public class ExpressNode
    {
        public DllNode DNode;
        public ExpressNode Next;
        public ExpressNode Lower;
        public ExpressNode(DllNode d)
        {
            DNode = d;
            Next = null;
            Lower = null;
        }
    }
}