using System;
using System.Text;

public class Baitap23
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
       while (true)
        {
            string str = "Hello, world!";
            Console.Write("Nhập một ký tự: ");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == character)
                {
                    count++;
                }
            }
            Console.WriteLine("Số lần xuất hiện của ký tự '{0}' trong chuỗi là: {1}", character, count);
        }
    }
}