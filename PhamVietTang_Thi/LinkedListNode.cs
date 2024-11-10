using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23DH113104_PhamVietTang
namespace PhamVietTang_Thi
{
    internal class LinkedListNode
    {
        public string Meaning { get; set; }
        public LinkedListNode Next { get; set; }

        public LinkedListNode(string meaning)
        {
            Meaning = meaning;
            Next = null;
        }
    }
}
