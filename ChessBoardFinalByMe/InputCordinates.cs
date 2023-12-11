using System;

namespace ChessBoardFinalByMe
{
    public static class InputCordinates
    {
        public static void Input()
        {
            Console.WriteLine("Enter the coordinates(e.g., A1):");
            string input = Console.ReadLine();

            char letter = input[0];
            if (int.TryParse(input.Substring(1), out int num))
            {
                switch (char.ToUpper(letter))
                {
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'E':
                    case 'F':
                    case 'G':
                    case 'H':
                        if (num >= 1 && num <= 8)
                        {
                            Console.WriteLine($"Valid Coordinates: {letter}{num}");
                            DrawChessBoard.Drawer(letter, num);
                        }
                        else
                        {
                            Console.WriteLine("Invalid rank.Please enter a rank between 1 and 8");
                            Input();
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid file.Please Enter a file between A and H.");
                        Input();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input format. Please enter coordinates in the format A1.");
                Input();
            }
        }
    }
}

