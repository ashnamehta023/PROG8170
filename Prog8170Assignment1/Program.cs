using System;

namespace Prog8170Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, width;
            string inputLength, inputWidth;

            try
            {
                do
                {
                    Console.WriteLine("Enter Length: ");
                    inputLength = Console.ReadLine();
                }
                while (!int.TryParse(inputLength, out length) || length < 1);

                do
                {
                    Console.WriteLine("Enter Width: ");
                    inputWidth = Console.ReadLine();
                }
                while (!int.TryParse(inputWidth, out width) || width < 1);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}
