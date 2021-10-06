using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Game
    {
        private static bool _applicationShouldExit;
        // Checks if the game has ended yet 
        private bool gameOver = false;
        // Creats an instance of a board 
        private Board _gameBoard;

        /// <summary>
        /// Runs the Starts, Draw, Updatw and End Functions 
        /// </summary>
        public void Run()
        {
            Start();

            while (!gameOver)
            {
                Draw();
                Update();
            }

            End();
        }

        /// <summary>
        /// Initilazes The Board
        /// </summary>
        private void Start()
        {
            _gameBoard = new Board();
            _gameBoard.Start();
        }

        private void Draw()
        {
            Console.Clear();
            _gameBoard.Draw();
            
        }

        private void Update()
        {
            _gameBoard.Update();
        }

        private void End()
        {
            _gameBoard.End();
        }

        public static int GetInput()
        {
            int choice = -1;
            if (!int.TryParse(Console.ReadLine(), out choice))
                choice = -1;
            if (choice > 9)
                choice = -1;

            return choice;
        }
    }
}
