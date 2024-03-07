using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vietphuongthucdemsolanxuathiencuakytutrongchuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Đảm bảo kí tự Unicode được hiển thị đúng trên Console
            char input_char;
            string str;
            Console.WriteLine("Nhap chuoi ky tu: ");
            str = Console.ReadLine();
            Console.Write("Nhap mot ky tu: ");
            input_char = Console.ReadKey().KeyChar;
            int count = 0;
            for (int i = 0; i < str.Length;i++)
            {
                if (input_char == str[i])
                {
                    count++;
                }
            }
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("Ky tu {0} xuat hien {1} lan trong chuoi.",input_char,count);
            Console.ReadKey();
        }
    }
}
