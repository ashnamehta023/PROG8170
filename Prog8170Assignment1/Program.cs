using System;

namespace Prog8170Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int length, width, menuChoice;
            string inputLength, inputWidth;

            try
            {
                //getting legth and width
                SetLengthFromUser();
                SetWidthFromUser();                

                //declaring object using the length and width user provides.
                Rectangle recObject = new Rectangle(length, width);
                do
                {
                    //Menu display
                    Console.Write("\n___________________________________________\n");
                    Console.Write("Welcome to rectangle calculations!");
                    Console.Write("\n 1. Get Length of Rectangle");
                    Console.Write("\n 2. Change Length");
                    Console.Write("\n 3. Get Width of Rectangle");
                    Console.Write("\n 4. Change Width");
                    Console.Write("\n 5. Get Rectangle Perimeter");
                    Console.Write("\n 6. Get Rectangle Area");
                    Console.Write("\n 7. Exit");
                    Console.Write("\n___________________________________________\n");
                    Console.Write("\n Enter Your Choice from 1 to 7 : ");
                    menuChoice = int.Parse(Console.ReadLine());


                    //Switch to control menu options
                    int result;
                    switch (menuChoice)
                    {
                        case 1:
                            result = recObject.GetLength();
                            Console.Write("\n Length of Rectangle :" + result);
                            break;
                        case 2:
                            SetLengthFromUser();
                            result = recObject.SetLength(length);
                            Console.Write("\n Length changed to :" + result);
                            break;
                        case 3:
                            result = recObject.GetWidth();
                            Console.Write("\n Width of Rectnagle : " + result);
                            break;
                        case 4:
                            SetWidthFromUser();
                            result = recObject.SetWidth(width);
                            Console.Write("\n Width changed to :" + result);
                            break;
                        case 5:
                            result = recObject.GetPerimeter();
                            Console.Write("\n Perimeter of Rectangle : " + result);
                            break;
                        case 6:
                            result = recObject.GetArea();
                            Console.Write("\n Area of Rectangle : " + result);
                            break;
                        case 7:
                            Console.Write("\n Thank you! \n ");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("\n Invalid Choice");
                            break;
                    }
                }
                while (menuChoice != 7);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            void SetLengthFromUser()
            {
                Console.WriteLine("Enter Length: ");
                do
                {

                    inputLength = Console.ReadLine();
                    if (!int.TryParse(inputLength, out length) || length < 1)
                    {
                        Console.WriteLine("Length can be only int and greater than 0");
                        Console.WriteLine("Enter Length again: ");
                    }
                }
                while (!int.TryParse(inputLength, out length) || length < 1);
            }

            void SetWidthFromUser()
            {
                Console.WriteLine("Enter Width: ");
                do
                {
                    inputWidth = Console.ReadLine();
                    if (!int.TryParse(inputWidth, out width) || width < 1)
                    {
                        Console.WriteLine("Width can be only int and greater than 0");
                        Console.WriteLine("Enter Width again: ");
                    }
                }
                while (!int.TryParse(inputWidth, out width) || width < 1);
            }

        }
    }
}
