using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = new DateTime();

            //date = DateTime.Now;
            //date.AddDays(1);
            //date.AddHours(1);


            ////Console.WriteLine(string.Format("{0:C}", temp));

            ////Console.WriteLine(string.Format("{0:dd/MM/yy H:mm:ss}", date));

            ////Console.WriteLine(string.Format("It is now {0:d} at {0:t}", DateTime.Now));

            ////&& and

            //// || or

            //// !

            //// = ==

            ////double temp = 12;

            ////if (temp != 11)
            ////    Console.WriteLine("They are equal");

            //bool first = true;
            //bool second = false;

            //if (first)//first is true
            //{
            //    Console.WriteLine("Inside the first for");
            //}

            //if (!first)//first is true
            //{
            //    Console.WriteLine("Inside the second for");
            //}

            //if (second)//second is false
            //{
            //    Console.WriteLine("Inside the third for");
            //}

            //if (!second)//second is false
            //{
            //    Console.WriteLine("Inside the forth for");
            //}

            //if (first && second)//first is true, second is false
            //{
            //    Console.WriteLine("inside the fifth for");
            //}

            //if (first && !second)//first is true, second is false
            //{
            //    Console.WriteLine("inside the sixth for");
            //}

            //if (!first && !second)//first is true, second is false
            //{
            //    Console.WriteLine("inside the seventh for");
            //}

            //if (first || second)//first is true, second is false
            //{
            //    Console.WriteLine("inside the eigth for");
            //}

            //if (first || !second)//first is true, second is false
            //{
            //    Console.WriteLine("inside the ninth for");
            //}

            //if (!first || !second)//first is true, second is false
            //{
            //    Console.WriteLine("inside the tenth for");
            //}

            //if (1 + 5 == 7)
            //{
            //    Console.WriteLine("inside the eleventh for");
            //}

            //Console.WriteLine("please enter a number");
            //string question = Console.ReadLine();
            //int number = Convert.ToInt32(question);

            //if (number < 10 && number > 2)//3-9
            //{
            //    //Play game
            //    Console.WriteLine("Playing game");
            //    if (true)
            //    {

            //    }
            //}
            //else if (number == 5)//only 5
            //{
            //    Console.WriteLine("You want to play the fifth level");
            //}
            //else if (number > 20)//21+
            //{
            //    Console.WriteLine("You want to play the advanced level");
            //}
            //else if (number == 1)//only the number 1
            //{
            //    Console.WriteLine("You want to play the intro level");
            //}
            //else//everything else
            //{
            //    Console.WriteLine("sorry you don't want to play");
            //}

            ////if (number == 5)//only 5
            ////{
            ////    Console.WriteLine("You want to play the fifth(2) level");
            ////}

            ////    Console.WriteLine("please enter a number");
            ////string question = Console.ReadLine();
            ////int number = Convert.ToInt32(question);


            //switch (number)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("you selected {0}", number);
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine("you selected {0}", number);
            //            break;
            //        }
            //    case 3:
            //        {
            //            Console.WriteLine("you selected {0}", number);
            //            break;
            //        }
            //    case 4:
            //        {
            //            Console.WriteLine("you selected {0}", number);
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("you selected {0}", number);
            //            break;
            //        }
            //}

            //switch (number)
            //{
            //    default:
            //        break;
            //}

            //bool gameOver = false;
            //int counter = 0;

            //while (!gameOver)
            //{
            //    Console.WriteLine("In the Loop");

            //    counter++;

            //    if (counter > 10)
            //        break; 
            //}

            bool goAgain = true;
            while (goAgain)
            {
                //Console.WriteLine("How many loops?");
                //string loop = Console.ReadLine();
                //int loops = Convert.ToInt32(loop);

                //for (int i = 0; i < loops; i++)
                //{
                //    Console.WriteLine("Loop {0}", i);
                //}

                Random rand = new Random(DateTime.Now.Millisecond);

                Console.WriteLine(rand.Next(1, 9));

                Console.WriteLine("Do you want to go again? (y/n)");
                string answer = Console.ReadLine();

                if (answer != "y")
                    goAgain = false;
            }

            Console.ReadKey();
        }
    }
}
 