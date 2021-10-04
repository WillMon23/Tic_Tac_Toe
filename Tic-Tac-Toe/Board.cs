﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Board
    {
        private char _player1Token;
        private char _player2Token;
        private char _currentToken;
        private char[,] _board;

        /// <summary>
        /// Initalzies players tokens and the game board
        /// </summary>
        public void Start()
        {
            _player1Token = 'x';
            _player2Token = 'o';
            _player2Token = _player1Token;
            _board = new char[3, 3]
            {{ '1', '2', '3' },
             { '4', '5', '6',}, 
             { '7', '8', '9' }};
        }                          

        /// <summary>
        /// Draws the board to the console and let's the player know whose turn it is
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("\n  " +_board[0, 0] + " | " + _board[0, 1] + " | " + _board[0, 2]  +
              "\n ----------\n" +
              "\n  " + _board[1, 0] + " | " + _board[1, 1] + " | " + _board[1, 2] +
              "\n ----------\n" +
              "\n  " + _board[2, 0] + " | " + _board[2, 1] + " | " + _board[2, 2]);
        }


        /// <summary>
        /// Gets Input from the player.Sets the plaer token at the desired spot in the 2Darray 
        /// Checks if there is a winner.
        /// Changes the current token in play 
        /// </summary>
        public void Update()
        {
            if (Game.GetInput() == 1)
            {
                _board[0, 0] = _currentToken; 
            }

            if (_currentToken == _player1Token)
                _currentToken = _player2Token;
            else
                _currentToken = _player1Token;
        }

        public void End()
        {

        }

        /// <summary>
        /// Assigns the spot at the given indices in the board array to be the given token
        /// </summary>
        /// <param name="token">The Token to set the  array index to</param>
        /// <param name="posX">The x position of the token</param>
        /// <param name="posY">The y position of the token</param>
        /// <returns>returns false if he incides are out of range </returns>
        public bool SetToken(Char token, int posX, int posY)
        {
            return false;
        }

        /// <summary>
        /// Checks to see if the tooken appear three times consecutively vertically, horizontally or diagonally
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool CheckWinner(char token)
        {
            return false;
        }

        /// <summary>
        /// Resets the board to it's 
        /// </summary>
        public void ClearBoard()
        {

        }

    }
}
