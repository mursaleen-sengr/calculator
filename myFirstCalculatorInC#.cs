using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR1
{
    internal class Program
    {

        public static void Addition(int num1 ,int num2 )
        {
            int result = num1+num2;
            Console.WriteLine( " your addition result is : {0}  ", result);

        }

        public static void Substraction (int num1, int num2)
        {
            int result = num1-num2;
            Console.WriteLine(" your substraction result is : {0}  ", result);

        }

        public static void multiplication(int num1, int num2)
        {
            int result = num1*num2;
            Console.WriteLine(" your multiplcation result is : {0}  ", result);

        }

        public static void Division (int num1, int num2)
        {
            int result = num1/num2;
            Console.WriteLine(" your division result is : {0}  ", result);

        }

        static void Main(string[] args)
        {
            Console.WriteLine(" enter first number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter second number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter + for addition \n enter - for substraction \n enter * for multiplcation \n enter / for division : ");
            string sign = (Console.ReadLine());


            if( sign == "+")
            {
                Program.Addition(num1, num2);

            }
            else  if (sign == "-")
            {
                Program.Substraction(num1, num2);

            }
            else if (sign == "*")
            {
                Program.multiplication(num1, num2);

            }
            else if (sign == "/")
            {
                Program.Division(num1, num2);

            }

            else
            {
                Console.WriteLine(" Invalid Entry ");
            }



            Console.ReadLine();








        }
    }
}
