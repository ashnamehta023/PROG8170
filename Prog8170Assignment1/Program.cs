using System;

namespace Prog8170Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint length;
            uint width;

            do
            {
                Console.WriteLine("Enter Length: ");
                length = uint.Parse(Console.ReadLine());
            }
            while(length > 0);

            do
            {
                Console.WriteLine("Enter Width: ");
                width = uint.Parse(Console.ReadLine());
            }
            while (width > 0);

            Console.ReadLine();

        }
    }
}
