//Stephen Burgess
//Loops


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_7_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*/

            Console.WriteLine("For Loop");

            for (int counter = 1; counter <= 12; counter++)
            {

                Console.WriteLine($" {counter} x 7 = {counter * 7}");


            }

            Console.WriteLine("While Loop Times Table");
            int finish = 12;
            int counter2 = 1;
            while (counter2 <= finish)
            {

                Console.WriteLine($" {counter2} x 7 = {counter2 * 7}");
                counter2++;
            }



            Console.WriteLine("Do while loop times table");
            counter2 = 1;
            do
            {

                Console.WriteLine($" {counter2} x 7 = {counter2 * 7}");
                counter2++;

            }
            while (counter2 <= finish);
            Console.ReadLine();

            /*/

            /*/


            Console.WriteLine("While Loop Table Example");



            int finish = 7;
            int counter = 1;
            while (counter <= finish)
            {

                Console.WriteLine($" {counter}\t\t{counter * 2}\t\t{counter * 3}\t\t{counter * 4}");
                counter++;

            }
            Console.WriteLine("End of the while loop");
            Console.ReadLine();



            /*/

            //Odd Numbers Loop

            /*/

            Console.WriteLine("Odd Numbers Loop");
            
            int finish = 46;
            int counter = 76;
            while (counter >= finish)
            {
                if (counter % 2 != 0)
                
                   Console.WriteLine($"{counter}");
                   counter--;
                

               

            }
            Console.ReadLine();

    /*/

            /*/

            //For loop
            Console.WriteLine("For Loop");
            Console.WriteLine("Number\tSquare\tCube");
            Console.WriteLine("For Loop");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i}\t{i * i}\t{i * i * i}");
            }
            

            //while loop
            Console.WriteLine("Do while loop");
            int counter = 0;
            while (counter <=10)
            {

                Console.WriteLine($"{counter}\t{counter * counter}\t {counter * counter * counter}");
                counter++;
            }

            //do while loop
            Console.WriteLine("Do while loop");
            counter = 0;

            do
            {
                Console.WriteLine($"{counter}\t{counter * counter}\t {counter * counter * counter}");
                counter++;
            } while (counter <= 10);
            Console.ReadLine();

            /*/

            /*/
            Console.WriteLine("Repeat Character For Loop");
            Console.WriteLine("Enter a character");
            string character = (Console.ReadLine());
            Console.WriteLine($"Enter how many times you want it to repeat {character}: ");
            int num1 = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= num1; i++)
            {
                Console.WriteLine($" {character}");
            }
            Console.ReadLine();

            /*/

            //rectangle of characters

            Console.WriteLine("Please enter a symbol to use");
            string symbol = Console.ReadLine();
            Console.WriteLine("Please enter the height of the rectangle");

            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of the rectangle");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nTask 3 end...");
            Console.ReadLine();

       


             








        }
    }
}
