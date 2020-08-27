using System;

namespace Methods_with_Loops_and_Conditionals
{
    class Program
    {

        public static decimal Lukewarmsmethod_1(int lukesnumber  )
        {
            while (lukesnumber < 1001)
            {
                lukesnumber++;
                Console.WriteLine(lukesnumber);
            }
            return lukesnumber;
        }


        public static void Threebythreemethod(int three )
        {
           while (three <= 999)
            {
                three += 3;
                Console.WriteLine(three);
            }
        }
            

        public static void equalitytesterMk1(int A, int B)
        {
            if (A == B)
            {
                Console.WriteLine(true);
                Console.WriteLine($"Yes, {A} and {B} are indeed equal to one another.");

            }
            else
            {
                Console.WriteLine(false);
                Console.WriteLine($"No, {A} and {B} are NOT equal. Program exiting.");
            }
        }


        public static void PositiveorNegative(int integer)
        {
            if (integer >= 0)
            {
                Console.WriteLine($" {integer} is clearly a positive number ");

            }

            else
            {
                Console.WriteLine($"{integer} is a negative number");
            }
        }


        public static void CanYouVoteYet(int age  )
        {

    
          if (age < 18 )
            {
               
                Console.WriteLine($"Sorry kiddo, but at {age} you cannot vote");
                
            }

          else if(age >= 18 )
            {
                Console.WriteLine("Ok Sir/Madam, You MAY vote. Right this way if You don't mind.");
            }
        }


      
        static void Main(string[] args)
        {
            Lukewarmsmethod_1(-1000);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------- \n");
            Threebythreemethod(3);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------- \n");
            equalitytesterMk1(11, 10);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------- \n");
            PositiveorNegative(5);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------- \n");
            CanYouVoteYet(15);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------- \n");


        }
    }
}
