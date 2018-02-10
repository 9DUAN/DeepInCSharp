using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepInCSharp.第一章_进化史
{
    class 怎样写出酷炫代码
    {
        static string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        [STAThread]//Snippy调用内嵌类、相当于using
        static void Mains()//“/main”
        {
            Console.WriteLine(Reverse("olleH"));

            Console.ReadLine();

        }
    }
}
