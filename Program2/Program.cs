using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {

            Book newBook = new Book("Stunnin ", "Curtis ", 10);
            

            Book secondBook = new Book("Not Stunnin","Not Curtis",20);

            //Redundant code
            //secondBook.title = "Not Stunnin'";
            //secondBook.author = "Not Curtis";
            //secondBook.pages = 20;


            Console.WriteLine("Hello World!");
            Console.WriteLine("");



            int[] number = { 4, 5, 6 };


            Console.WriteLine(number[0]);
            //Prints out 4

            //Changes 4 to 1
            number[0] = 1;

            Console.WriteLine(number[0]);

            string[] people = { "Bob", "Tony", "Mike" };

            string[] friends = new string[10];

            friends[0] = "Bob";
            friends[1] = "Mike";


            //Calling other main method INSIDE MAIN
            MethodName();

            int x = 2;
            int y = 3;
            Console.WriteLine(AnotherMethod(x, y));


            Console.WriteLine(Cubed(y));


            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)
            {

                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("Sorry you are not tall, have to be 6ft");
            }
            else
            {
                Console.WriteLine("You are a filthy animal");
            }


            int number1 = 0;

            int number2 = 0;
            int result = 0;

            //Console.WriteLine("Enter a function: ");

            string function = Console.ReadLine();

            for (int i = 0; i < function.Length; i++)
            {
                char c = function[i];


                if (Char.IsDigit(c))
                {

                    number1 = Convert.ToInt32(c);


                }
                if (Char.IsDigit(function[i]))
                {
                    number2 = Convert.ToInt32(c);
                }

                string op = Convert.ToString(function[i]);

                switch (op)
                {
                    case "+":
                        result = Convert.ToInt32(number1) + Convert.ToInt32(number2);

                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                }


            }

            //Console.WriteLine(Convert.ToInt32(result));


            int index = 1;

            while (index <= 3)
            {
                Console.WriteLine(index);
                index++;

            }

            //do this before checking condition

            //while ();



            //2d array. comma inside []
            //, 2d   ,, 3d  ,,, 4d
            int[,] numberGrid = {
                { 1, 2},
                { 3, 4},
                { 5, 6}

            };
            //row, column
            Console.WriteLine(numberGrid[1, 1]);


            //how many rows and columns we want. 
            int[,] test = new int[2, 3];



            //handle exception
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //always going to be executed no matter what

            }


        }


        //void method means no return
        static void MethodName()
        {

            Console.WriteLine("New method");

        }

        static int AnotherMethod(int x, int y)
        {
            x += y;

            return x;


        }



        static int Cubed(int num)
        {
            int result = num * num * num;
            // cant do Math.Pow(num, 3);
            return result;
        }







    }
}
