using System;
using System.Collections.Generic;
namespace Tries
{
    public class TriNode 
    {
        public char Value;
        public List<TriNode> Next;
        // v Is set to true when next is empty v
        public bool isWord;
        public TriNode(char val, List<TriNode> next, bool word)
        {
            Value = val;
            Next = next;
            isWord = word;
        }
    }
}