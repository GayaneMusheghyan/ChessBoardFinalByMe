using System;
using static ChessBoardFinalByMe.MoveCheck;

namespace ChessBoardFinalByMe
{
    public static class InputWhichPieceMove
    {
        public static void Checking()
        {
            {
                Console.WriteLine("Enter a chess piece (K, Q, R, N, B):");

                // Read a line of input
                string input = Console.ReadLine();

                // Check if the input is a valid chess piece
                if (IsChessPiece(input))
                {
                    Console.WriteLine($"You entered a valid chess piece: {input}");
                    Console.Write("Enter current coordinates (e.g., c2): ");
                    string currentInput = Console.ReadLine();
                    ChessCoordinate current = ParseCoordinate(currentInput);

                    Console.Write("Enter destination coordinates (e.g., a1): ");
                    string destinationInput = Console.ReadLine();
                    ChessCoordinate destination = ParseCoordinate(destinationInput);

                    Console.WriteLine($"Current coordinates: {current}");
                    Console.WriteLine($"Destination coordinates: {destination}");

                    if (input.ToUpper() == "K")
                    {
                        // Use ChessValidator to check if the king can move
                        bool canMoveKing = ChessValidator.CanKingMove(current, destination);
                        //// Display the result
                        Console.WriteLine($"Can king move from {current} to {destination}? {canMoveKing}");
                    }
                    if (input.ToUpper() == "N")
                    {
                        // Use ChessValidator to check if the knight can move
                        bool canMoveKnight = ChessValidator.CanKnightMove(current, destination);
                        //// Display the result
                        Console.WriteLine($"Can knight move from {current} to {destination}? {canMoveKnight}");
                    }
                    if (input.ToUpper() == "R")
                    {
                        // Use ChessValidator to check if the rook can move
                        bool canMoveRook = ChessValidator.CanRookMove(current, destination);
                        //// Display the result
                        Console.WriteLine($"Can Rook move from {current} to {destination}? {canMoveRook}");
                    }
                    if (input.ToUpper() == "Q")
                    {
                        // Use ChessValidator to check if the queen can move
                        bool canMoveQueen = ChessValidator.CanQueenMove(current, destination);
                        //// Display the result
                        Console.WriteLine($"Can Queen move from {current} to {destination}? {canMoveQueen}");
                    }
                    if (input.ToUpper() == "B")
                    {
                        // Use ChessValidator to check if the bishop can move
                        bool canMoveBishop = ChessValidator.CanBishopMove(current, destination);
                        //// Display the result
                        Console.WriteLine($"Can Bishop move from {current} to {destination}? {canMoveBishop}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter K, Q, R, N, B.");
                }
            }
            static bool IsChessPiece(string input)
            {
                // Check if the input is one of the valid chess pieces
                return input.ToUpper() == "K" || input.ToUpper() == "N" || input.ToUpper() == "R" || input.ToUpper() == "Q" || input.ToUpper() == "B";
            }
        }
    }
}

