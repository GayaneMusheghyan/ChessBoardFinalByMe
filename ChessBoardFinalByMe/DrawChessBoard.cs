using System;

namespace ChessBoardFinalByMe
{
    public class DrawChessBoard
    {
        public static void Drawer(char letter = '0', int num = 0)
        {
            Console.WriteLine("  A B C D E F G H");
            for (int row = 8; row >= 1; row--)
            {
                Console.Write(row + "|");
                for (char col = 'A'; col <= 'H'; col++)
                {
                    if (row == num && col == char.ToUpper(letter))
                    {
                        if ((row + col) % 2 == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(" X");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(" X");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        if ((row + col) % 2 == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                        }
                        Console.Write("  ");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine("|" + row);
            }
            Console.WriteLine("  A B C D E F G H");
        }
    }
}

