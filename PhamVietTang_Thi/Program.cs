// See https://aka.ms/new-console-template for more information
using PhamVietTang_Thi;

//23DH113104_PhamVietTang
class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        DictionaryBST dictionary = new DictionaryBST();
        int choice;

        do
        {
            Console.WriteLine("\n--- Quản lý từ điển Anh - Việt ---");
            Console.WriteLine("1. Thêm từ mới");
            Console.WriteLine("2. Tìm kiếm từ");
            Console.WriteLine("3. In danh sách từ");
            Console.WriteLine("0. Thoát");
            Console.Write("Lựa chọn của bạn: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Nhập từ tiếng Anh: ");
                    string englishWord = Console.ReadLine();
                    Console.Write("Nhập nghĩa của từ: ");
                    string meaning = Console.ReadLine();
                    dictionary.AddWord(englishWord, meaning);
                    break;

                case 2:
                    Console.Write("Nhập từ tiếng Anh cần tìm kiếm: ");
                    string searchWord = Console.ReadLine();
                    dictionary.SearchWord(searchWord);
                    break;

                case 3:
                    Console.WriteLine("Danh sách từ trong từ điển:");
                    dictionary.DisplayAllWords();
                    break;

                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        } while (choice != 0);
    }
}

