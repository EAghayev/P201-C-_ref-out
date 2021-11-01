using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            string countStr;
            do
            {
                Console.WriteLine("Kitablarin sayini daxil edin:");
                countStr = Console.ReadLine();

            } while (!int.TryParse(countStr,out count) || count<0);

            LibraryStore library = new LibraryStore();
            library.Books = new Book[]
            {
                new Book(1,"test1",45,"dedektiv"),
                new Book(4,"test2",25,"dedektiv"),
                new Book(5,"test3",55,"dram"),
            };

            foreach (var item in library.Books)
            {
                Console.WriteLine(item.GetInfo());
            }

            for (int i = 0; i < count; i++)
            {
                bool check = false;
                int no;
                string noStr;
                do
                {
                    if (!check) Console.WriteLine("No deyerini daxil edin:");

                    noStr = Console.ReadLine();
                    check = true;

                    if(!int.TryParse(noStr,out no))
                    {
                        Console.WriteLine("No deyerini eded olaraq daxil edin!!!");
                        continue;
                    }

                    if (!CheckNo(no, library)) continue;

                    check = false;

                } while (check);


               
            }
        }

        static string GetInputStr()
        {
            string str = Console.ReadLine();
            return str;
        }

        static bool CheckNo(int no,LibraryStore library)
        {
            if (library.IsExistByNo(no))
            {
                Console.WriteLine($"{no} nomreli kitab elave edilib, yeni bir nomre daxil edin!");
                return false;
            }

            if (no < 0)
            {
                Console.WriteLine("No deyeri 0-dan kicik oal bilmez!");
                return false;
            }

            return true;
        }
       
    }
}
