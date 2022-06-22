using System;

namespace Tri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string areatri;
            Console.WriteLine("Select Area of Py");
            Console.WriteLine("Type 'area' or 'py' with no caps.");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "area")
            {
                Console.WriteLine("What is the value of one side of the triangle: ");
               float sidea =int.Parse( Console.ReadLine());
                Console.WriteLine("What is the value of the other side of the triangle: ");
                float sideb = int.Parse(Console.ReadLine());
                

               float sum= ((sidea * sideb)/2);

                Console.WriteLine("          /|");
                Console.WriteLine("         / |");
                Console.WriteLine("        /  |");
                Console.WriteLine("       /   |");
                Console.WriteLine("      /    |       Area =" + sum +"cm^2");
                Console.WriteLine("     /     |");
                Console.WriteLine("    /      |");
                Console.WriteLine("   /       |");
                Console.WriteLine("  /        |");
                Console.WriteLine(" /_________|");

            }
            else if(answer == "py")
            {
                Console.WriteLine("What is the value of one side of the triangle: ");
                float sidea = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the value of the other side of the triangle: ");
                float sideb = int.Parse(Console.ReadLine());

                float bsq = (sideb * sideb);
                float asq = (sidea * sidea);
                float csq = (bsq + asq);
                double c = Math.Sqrt(csq);
                Math.Round(c, 2);
                Console.WriteLine("                               /|");
                Console.WriteLine("                              / |");
                Console.WriteLine("                             /  |");
                Console.WriteLine("                            /   |");
                Console.WriteLine("                    "+Math.Round(c, 2)+"cm" + " /    | " + sidea + "cm");
                Console.WriteLine("                          /     |");
                Console.WriteLine("                         /      |");
                Console.WriteLine("                        /       |");
                Console.WriteLine("                       /        |");
                Console.WriteLine("                      /_________|");
                Console.WriteLine("                          " +        sideb +"cm"        );
                Console.WriteLine("Rounded to 2 decimal places.");
            }
        }
    }
}