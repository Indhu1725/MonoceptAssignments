using System;

namespace FacadeExample
{
    // Subsystem 1: Board
    class Board
    {
        private char[,] grid = new char[3, 3];

        public Board()
        {
            Reset();
        }

        public void Reset()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    grid[i, j] = ' ';
        }

        public bool SetMark(int row, int col, char mark)
        {
            if (grid[row, col] == ' ')
            {
                grid[row, col] = mark;
                return true;
            }
            return false;
        }

        public char GetMark(int row, int col)
        {
            return grid[row, col];
        }

        public void ShowBoard()
        {
            Console.WriteLine("\nBoard:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($" {grid[i, 0]} | {grid[i, 1]} | {grid[i, 2]} ");
                if (i < 2) Console.WriteLine("---|---|---");
            }
        }
    }

    // Subsystem 2: Rules
    class Rules
    {
        public bool HasWinner(Board board, char player)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((board.GetMark(i, 0) == player &&
                     board.GetMark(i, 1) == player &&
                     board.GetMark(i, 2) == player) ||

                    (board.GetMark(0, i) == player &&
                     board.GetMark(1, i) == player &&
                     board.GetMark(2, i) == player))
                    return true;
            }

            if ((board.GetMark(0, 0) == player &&
                 board.GetMark(1, 1) == player &&
                 board.GetMark(2, 2) == player) ||

                (board.GetMark(0, 2) == player &&
                 board.GetMark(1, 1) == player &&
                 board.GetMark(2, 0) == player))
                return true;

            return false;
        }

        public bool IsBoardFull(Board board)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board.GetMark(i, j) == ' ')
                        return false;

            return true;
        }
    }

    // Subsystem 3: Player
    class Player
    {
        private char current = 'X';

        public char CurrentPlayer()
        {
            return current;
        }

        public void ChangePlayer()
        {
            current = (current == 'X') ? 'O' : 'X';
        }
    }

    // Facade Class
    class GameFacade
    {
        private Board board = new Board();
        private Rules rules = new Rules();
        private Player player = new Player();

        public void StartGame()
        {
            Console.WriteLine("=== Tic Tac Toe Game ===");
            board.ShowBoard();

            while (true)
            {
                Console.WriteLine($"\nPlayer {player.CurrentPlayer()} turn:");
                Console.Write("Enter row and column (0-2): ");

                string[] input = Console.ReadLine().Split(' ');
                int row = int.Parse(input[0]);
                int col = int.Parse(input[1]);

                if (!board.SetMark(row, col, player.CurrentPlayer()))
                {
                    Console.WriteLine("Invalid move! Try again.");
                    continue;
                }

                board.ShowBoard();

                if (rules.HasWinner(board, player.CurrentPlayer()))
                {
                    Console.WriteLine($" Player {player.CurrentPlayer()} Wins!");
                    break;
                }

                if (rules.IsBoardFull(board))
                {
                    Console.WriteLine("Game Draw!");
                    break;
                }

                player.ChangePlayer();
            }
        }
    }

    // Client
    class Program
    {
        static void Main(string[] args)
        {
            GameFacade game = new GameFacade();
            game.StartGame(); // Only one method call (Facade)
        }
    }
}