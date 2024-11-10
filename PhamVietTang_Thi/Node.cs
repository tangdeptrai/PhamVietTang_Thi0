using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23DH113104_PhamVietTang
namespace PhamVietTang_Thi
{
    internal class Node
    {
        public string EnglishWord { get; set; }
        public LinkedList Meanings { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(string englishWord, string meaning)
        {
            EnglishWord = englishWord;
            Meanings = new LinkedList();
            Meanings.AddMeaning(meaning);
            Left = Right = null;
        }
    }
}
