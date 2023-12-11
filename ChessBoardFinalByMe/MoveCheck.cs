using System;
using static ChessBoardFinalByMe.MoveCheck;

namespace ChessBoardFinalByMe
{
    public class MoveCheck
    {
        public struct ChessCoordinate
        {
            public char Letter { get; set; }
            public int Number { get; set; }

            public ChessCoordinate(char letter, int number)
            {
                Letter = letter;
                Number = number;
            }

            public override string ToString()
            {
                return $"{Letter}{Number}";
            }
        }


        public static ChessCoordinate ParseCoordinate(string input)
        {
            if (input.Length != 2)
            {
                Console.WriteLine("Invalid input. Please enter coordinates in the format (letter)(number), e.g., c2.");
                Environment.Exit(1);
            }

            char letter = char.ToLower(input[0]); // Convert the letter to lowercase
            if (!char.IsLetter(letter))
            {
                Console.WriteLine("Invalid letter in coordinates. Please enter a valid letter.");
                Environment.Exit(1);
            }

            int number;
            if (!int.TryParse(input[1].ToString(), out number))
            {
                Console.WriteLine("Invalid number in coordinates. Please enter a valid number.");
                Environment.Exit(1);
            }

            return new ChessCoordinate(letter, number);
        }
    }
}



public class GetCurrDestCoord
{
    public static void EnteringCoordToCheck()
    {
        Console.Write("Enter current coordinates (e.g., c2): ");
        string currentInput = Console.ReadLine();
        ChessCoordinate current = ParseCoordinate(currentInput);

        Console.Write("Enter destination coordinates (e.g., a1): ");
        string destinationInput = Console.ReadLine();
        ChessCoordinate destination = ParseCoordinate(destinationInput);

        Console.WriteLine($"Current coordinates: {current}");
        Console.WriteLine($"Destination coordinates: {destination}");

        bool canMoveKnight = ChessValidator.CanKnightMove(current, destination);
        Console.WriteLine($"Can knight move from {current} to {destination}? {canMoveKnight}");
    }
}

public static class ChessValidator
{
    public static bool CanKnightMove(ChessCoordinate current, ChessCoordinate destination)
    {
        // Knight moves in an L-shape: two squares in one direction and one square perpendicular
        int letterDifference = Math.Abs(destination.Letter - current.Letter);
        int numberDifference = Math.Abs(destination.Number - current.Number);

        return (letterDifference == 1 && numberDifference == 2) || (letterDifference == 2 && numberDifference == 1);
    }
    public static bool CanKingMove(ChessCoordinate current, ChessCoordinate destination)
    {
        // King moves to any adjacent square horizontally, vertically, or diagonally
        int letterDifference = Math.Abs(destination.Letter - current.Letter);
        int numberDifference = Math.Abs(destination.Number - current.Number);

        // Check if the destination is within one square in any direction
        return letterDifference <= 1 && numberDifference <= 1;
    }
    public static bool CanQueenMove(ChessCoordinate current, ChessCoordinate destination)
    {
        // Queen moves horizontally, vertically, or diagonally any number of squares
        int letterDifference = Math.Abs(destination.Letter - current.Letter);
        int numberDifference = Math.Abs(destination.Number - current.Number);

        // Check if the destination is either in the same row, same column, or on the same diagonal
        return current.Letter == destination.Letter ||      // Same column
               current.Number == destination.Number ||    // Same row
               letterDifference == numberDifference;      // Same diagonal
    }
    public static bool CanRookMove(ChessCoordinate current, ChessCoordinate destination)
    {
        // Rook moves horizontally or vertically any number of squares
        int letterDifference = Math.Abs(destination.Letter - current.Letter);
        int numberDifference = Math.Abs(destination.Number - current.Number);

        // Check if the destination is either in the same row or same column
        return current.Letter == destination.Letter ||   // Same column
               current.Number == destination.Number;     // Same row
    }

    public static bool CanBishopMove(ChessCoordinate current, ChessCoordinate destination)
    {
        // Bishop moves diagonally any number of squares
        int letterDifference = Math.Abs(destination.Letter - current.Letter);
        int numberDifference = Math.Abs(destination.Number - current.Number);

        // Check if the destination is along a diagonal
        return letterDifference == numberDifference;
    }
}


