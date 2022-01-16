using System;
using System.Threading;

namespace TicTac
{
    internal static class Program
    {
        private static readonly char[] _arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static int _player = 1;
        private static int _choice;
        private static int _chekWin = 0;

        private static void Main(string[] args)
        {
            Console.WriteLine("Player1:X and Player2:O");
            Console.WriteLine("\n");
            do
            {
                Console.Clear();
                Board();
                Console.WriteLine(_player % 2 == 0 ? "Player 2 Chance: " : "Player 1 Chance: ");

                _choice = int.Parse(Console.ReadLine() ?? string.Empty);
                if (_choice > 9)
                {
                    Console.WriteLine("Serious !! :)");
                    Thread.Sleep(2000);
                }
                else
                {
                    if (_arr[_choice] != 'X' && _arr[_choice] != 'O')
                    {
                        if (_player % 2 == 0) 
                        {
                            _arr[_choice] = 'O';
                            _player++;
                        }
                        else
                        {
                            _arr[_choice] = 'X';
                            _player++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry the row {0} is already marked with {1}", _choice, _arr[_choice]);
                        Console.WriteLine("\n");
                    }
                    _chekWin = CheckWin();
                }
            }
            while (_chekWin != 1 && _chekWin != -1);

            Console.Clear();
            Board();
            if (_chekWin == 1)
            {
                Console.WriteLine("Player {0} has won", (_player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _arr[1], _arr[2], _arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _arr[4], _arr[5], _arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _arr[7], _arr[8], _arr[9]);
            Console.WriteLine("     |     |      ");
        }
        private static int CheckWin()
        {

            if (_arr[1] == _arr[2] && _arr[2] == _arr[3])
            {
                return 1;
            } else if (_arr[4] == _arr[5] && _arr[5] == _arr[6])
            {
                return 1;
            }else if (_arr[6] == _arr[7] && _arr[7] == _arr[8])
            {
                return 1;
            }
            else if (_arr[1] == _arr[4] && _arr[4] == _arr[7])
            {
                return 1;
            }
            else if (_arr[2] == _arr[5] && _arr[5] == _arr[8])
            {
                return 1;
            }
            else if (_arr[3] == _arr[6] && _arr[6] == _arr[9])
            {
                return 1;
            }
            else if (_arr[1] == _arr[5] && _arr[5] == _arr[9])
            {
                return 1;
            }
            else if (_arr[3] == _arr[5] && _arr[5] == _arr[7])
            {
                return 1;
            }
            else if (_arr[1] != '1' && _arr[2] != '2' && _arr[3] != '3' && _arr[4] != '4' && _arr[5] != '5' && _arr[6] != '6' && _arr[7] != '7' && _arr[8] != '8' && _arr[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}