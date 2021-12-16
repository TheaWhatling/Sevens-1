using System;

namespace Sevens
{
    class Queue
    {
        private Player[] players;
        public const int SizeOfQueue = 4;
        private int CurrentPlayer;

        //SetCurrentPlayerIndex(0);

        public Player GetCurrentPlayer()//returns Player at current player index
        {
            return GetPlayerAt(GetCurrentPlayerIndex());
        }
        public Player GetNextPlayer()   //increments currentPlayerIndex to the next Player and returns the player at the currentPlayerIndex
        {
            SetCurrentPlayerIndex((GetCurrentPlayerIndex() + 1) % SizeOfQueue);

            return GetCurrentPlayer();
        }

        public Player[] GetQueue()
        {
            return players;
        }
        public void SetCurrentPlayerIndex(int input)
        {
            CurrentPlayer = input;
        }

        public int GetCurrentPlayerIndex()
        {
            return CurrentPlayer;
        }

        public Player GetPlayerAt(int position)
        {
            return players[position];
        }
    }
}