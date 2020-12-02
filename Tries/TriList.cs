using System;
namespace Tries
{
    public class TriList
    {
        public TriNode Head;
        public TriList()
        {
            Head = null;
        }
        public void Add(string str)
        {
            TriNode runner = Head;
            char[] charArr = str.ToCharArray();
            
        }
    }
}