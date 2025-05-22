using System;

namespace MyEnumerable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Guarda3<float> test1 = new Guarda3<float>();
            Guarda3<string> test2 = new Guarda3<string>();

            Console.WriteLine(test1.GetItem(0));
            Console.WriteLine(test2.GetItem(0));

            test2.SetItem(0, "Tralalelo tralala");
            test2.SetItem(1, "Capuccino assasino");
            test2.SetItem(2, "Tu tun tun tun ta");

            test1.SetItem(0, 1000.2f);
            test1.SetItem(1, 49.649f);
            test1.SetItem(2, 0.00000000004f);

            Console.WriteLine(test1.GetItem(0));
            Console.WriteLine(test1.GetItem(1));
            Console.WriteLine(test1.GetItem(2));

            Console.WriteLine(test2.GetItem(0));
            Console.WriteLine(test2.GetItem(1));
            Console.WriteLine(test2.GetItem(2));
        }
    }
}
