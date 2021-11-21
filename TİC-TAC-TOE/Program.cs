using System;

namespace TİC_TAC_TOE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;

            string s1 = " ", s2 = " ", s3 = " ", s4 = " ", s5 = " ", s6 = " ", s7 = " ", s8 = " ", s9 = " ";
            string T = "X";
            string input;
            int inputNumber = 0;
            int Tnumber = 0;
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("=======================");
            Console.WriteLine();

            int i = 0;

            while (i < 9)
            {
                Console.WriteLine($" {s1} | {s2} | {s3}");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" {s4} | {s5} | {s6}");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" {s7} | {s8} | {s9}");
                if (Tnumber % 2 == 0) T = "X";
                else T = "O";

                while (Tnumber < 9)

                {
                    Console.Write($"{T}'s move > ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out inputNumber)) continue;
                    switch (inputNumber)
                    {
                        case 1:
                            if (s1 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                continue;
                            }
                            s1 = T;
                            break;
                        case 2:
                            if (s2 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                continue;
                            }
                            s2 = T;
                            break;
                        case 3:
                            if (s3 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                continue;
                            }
                            s3 = T;
                            break;
                        case 4:
                            if (s4 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                continue;
                            }
                            s4 = T;
                            break;
                        case 5:
                            if (s5 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                continue;
                            }
                            s5 = T;
                            break;
                        case 6:
                            if (s6 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                continue;
                            }
                            s6 = T;
                            break;
                        case 7:
                            if (s7 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                continue;
                            }
                            s7 = T;
                            break;
                        case 8:
                            if (s8 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                continue;
                            }
                            s8 = T;
                            break;
                        case 9:
                            if (s9 != " ")
                            {
                                Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
                                continue;
                            }
                            s9 = T;
                            break;
                        default:
                            Console.WriteLine("ILLEGAL MOVE! TRY AGAIN");
                            continue;
                    }
                    i++;
                    Tnumber++;
                    break;
                }

            }
            Console.WriteLine("GAME OVER...");
        }
    }
}
