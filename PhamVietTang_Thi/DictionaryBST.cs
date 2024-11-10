using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23DH113104_PhamVietTang
namespace PhamVietTang_Thi
{
    internal class DictionaryBST
    {
        private Node root;

        public DictionaryBST()
        {
            root = null;
        }

        public void AddWord(string englishWord, string meaning)
        {
            root = AddWordRecursively(root, englishWord, meaning);
        }

        private Node AddWordRecursively(Node current, string englishWord, string meaning)
        {
            if (current == null)
            {
                Console.WriteLine("Thêm từ mới thành công!");
                return new Node(englishWord, meaning);
            }

            int compare = string.Compare(englishWord, current.EnglishWord, StringComparison.OrdinalIgnoreCase);

            if (compare < 0)
                current.Left = AddWordRecursively(current.Left, englishWord, meaning);
            else if (compare > 0)
                current.Right = AddWordRecursively(current.Right, englishWord, meaning);
            else
                Console.WriteLine("Từ đã tồn tại trong từ điển.");

            return current;
        }

        public void SearchWord(string englishWord)
        {
            Node node = SearchWordRecursively(root, englishWord);
            if (node != null)
            {
                Console.WriteLine($"Nghĩa của từ \"{englishWord}\":");
                node.Meanings.DisplayMeanings();
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ trong từ điển.");
            }
        }

        private Node SearchWordRecursively(Node current, string englishWord)
        {
            if (current == null) return null;

            int compare = string.Compare(englishWord, current.EnglishWord, StringComparison.OrdinalIgnoreCase);

            if (compare < 0)
                return SearchWordRecursively(current.Left, englishWord);
            else if (compare > 0)
                return SearchWordRecursively(current.Right, englishWord);
            else
                return current;
        }

        public void DisplayAllWords()
        {
            DisplayAllWordsRecursively(root);
        }

        private void DisplayAllWordsRecursively(Node current)
        {
            if (current != null)
            {
                DisplayAllWordsRecursively(current.Left);
                Console.WriteLine($"Từ: {current.EnglishWord}");
                current.Meanings.DisplayMeanings();
                DisplayAllWordsRecursively(current.Right);
            }
        }
    }
}
