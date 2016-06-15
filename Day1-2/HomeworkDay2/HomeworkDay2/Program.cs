using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameNotOver = true;
            string[] locations = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
            bool player1 = true;


            while (gameNotOver)
            {
                int spotCounter = 0;
                if (player1)
                {
                    Console.WriteLine(locations[0] + "|" + locations[1] + "|" + locations[2]);
                    Console.WriteLine("-----");
                    Console.WriteLine(locations[3] + "|" + locations[4] + "|" + locations[5]);
                    Console.WriteLine("-----");
                    Console.WriteLine(locations[6] + "|" + locations[7] + "|" + locations[8]);

                    Console.WriteLine("Please choose a location: ");
                    int xChoice;
                    string stringChoice = Console.ReadLine();

                    if (int.TryParse(stringChoice, out xChoice))
                    {
                        if ((xChoice >= 0 && xChoice <= 8) && (locations[xChoice] != "X" && locations[xChoice] != "O"))
                        {
                            locations[xChoice] = "X";
                            player1 = false;
                            Console.WriteLine("Press any button to start player 2's turn.");
                            Console.ReadKey();
                        }


                        else if ((xChoice >= 0 && xChoice <= 8) && (locations[xChoice] == "X" || locations[xChoice] == "O"))
                        {
                            Console.WriteLine("That choice is invalid, please try again.");
                        }

                        if ((locations[0] == "X") && (locations[1] == "X") && (locations[2] == "X"))
                        {
                            Console.WriteLine("YOU WIN!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }


                        else if ((locations[3] == "X") && (locations[4] == "X") && (locations[5] == "X"))
                        {
                            Console.WriteLine("YOU WIN!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }
                        else if ((locations[6] == "X") && (locations[7] == "X") && (locations[8] == "X"))
                        {
                            Console.WriteLine("YOU WIN!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }
                        else if ((locations[0] == "X") && (locations[3] == "X") && (locations[6] == "X"))
                        {
                            Console.WriteLine("YOU WIN!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }
                        else if ((locations[1] == "X") && (locations[4] == "X") && (locations[7] == "X"))
                        {
                            Console.WriteLine("YOU WIN!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }
                        else if ((locations[2] == "X") && (locations[5] == "X") && (locations[8] == "X"))
                        {
                            Console.WriteLine("YOU WIN!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }
                        else if ((locations[0] == "X") && (locations[4] == "X") && (locations[8] == "X"))
                        {
                            Console.WriteLine("YOU WIN!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }
                        else if ((locations[2] == "X") && (locations[4] == "X") && (locations[6] == "X"))
                        {
                            Console.WriteLine("YOU WIN!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }

                    }

                }

                else if (gameNotOver)
                {
                    Console.WriteLine(locations[0] + "|" + locations[1] + "|" + locations[2]);
                    Console.WriteLine("-----");
                    Console.WriteLine(locations[3] + "|" + locations[4] + "|" + locations[5]);
                    Console.WriteLine("-----");
                    Console.WriteLine(locations[6] + "|" + locations[7] + "|" + locations[8]);

                    Console.WriteLine("Please choose a location: ");
                    int oChoice;
                    string stringChoice = Console.ReadLine();

                    if (int.TryParse(stringChoice, out oChoice))
                    {
                        if ((oChoice >= 0 && oChoice <= 8) && (locations[oChoice] != "X" && locations[oChoice] != "O"))
                        {
                            locations[oChoice] = "O";
                            player1 = true;
                            Console.WriteLine("Press any button to start player 1's turn.");
                            Console.ReadKey();
                        }


                        else if ((oChoice >= 0 && oChoice <= 8) && (locations[oChoice] == "X" || locations[oChoice] == "O"))
                        {
                            Console.WriteLine("That choice is invalid, please try again.");
                        }

                        if ((locations[0] == "O") && (locations[1] == "O") && (locations[2] == "O"))
                        {
                            Console.WriteLine("YOU WIN, PLAYER 2!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }
                        else if ((locations[3] == "O") && (locations[4] == "O") && (locations[5] == "O"))
                        {
                            Console.WriteLine("YOU WIN, PLAYER 2!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }
                        else if ((locations[6] == "O") && (locations[7] == "O") && (locations[8] == "O"))
                        {
                            Console.WriteLine("YOU WIN, PLAYER 2!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }
                        else if ((locations[0] == "O") && (locations[3] == "O") && (locations[6] == "O"))
                        {
                            Console.WriteLine("YOU WIN, PLAYER 2!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }
                        else if ((locations[1] == "O") && (locations[4] == "O") && (locations[7] == "O"))
                        {
                            Console.WriteLine("YOU WIN, PLAYER 2!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }
                        else if ((locations[2] == "O") && (locations[5] == "O") && (locations[8] == "O"))
                        {
                            Console.WriteLine("YOU WIN, PLAYER 2!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }
                        else if ((locations[0] == "O") && (locations[4] == "O") && (locations[8] == "O"))
                        {
                            Console.WriteLine("YOU WIN, PLAYER 2!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }
                        else if ((locations[2] == "O") && (locations[4] == "O") && (locations[6] == "O"))
                        {
                            Console.WriteLine("YOU WIN, PLAYER 2!");
                            Console.ReadKey();
                            gameNotOver = false;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Please choose an open location that is between 0 and 8");
                            Console.ReadKey();
                        }
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    if (locations[i] == i.ToString())
                    {
                        spotCounter++;
                    }

                }
                if (spotCounter == 0)
                {
                    Console.WriteLine("You both lost.");
                    Console.ReadKey();
                    gameNotOver = false;
                }
            }
        }
    }
}