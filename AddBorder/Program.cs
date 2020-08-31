using System;

namespace AddBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter matrix height: ");
            int height = int.Parse(Console.ReadLine());
            string[] a = new string[height];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter raw: ");
                a[i] = Console.ReadLine();
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < a.Length + 2; i++)
            {
                Console.WriteLine(addBorder(a)[i]);
            }
            Console.ReadLine();
        }
        static string[] addBorder(string[] picture)
        {
            int iLength = picture[0].Length + 2;
            int iHeight = picture.Length + 2;
            string[] res = new string[iHeight];
            for (int i = 0; i < iLength; i++)
            {
                res[0] += "*";
            }
            for (int i = 0; i < picture.Length; i++)
            {
                res[i + 1] = "*" + picture[i] + "*";
            }
            for (int i = 0; i < iLength; i++)
            {
                res[iHeight - 1] += "*";
            }
            return res;
        }
    }
}
