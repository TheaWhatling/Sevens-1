using System;

namespace Sevens
{
    class Queue
    {
        private PlayerNode front;

        public Queue(Player p1, Player p2, Player p3, Player p4)
        {
            PlayerNode pnode1, pnode2, pnode3, pnode4;
            pnode1 = new PlayerNode();
            pnode2 = new PlayerNode();
            pnode3 = new PlayerNode();
            pnode4 = new PlayerNode();

            front = pnode1;
            pnode1.next = pnode2;
            pnode2.next = pnode3;
            pnode3.next = pnode4;
            pnode4.next = pnode1;

            pnode1.p = p1;
            pnode2.p = p2;
            pnode3.p = p3;
            pnode4.p = p4;
        }
        public Player GetCurrentPlayer()
        {
            return PlayerNode;
        }

        public void MoveOnToNextPlayer()
        {
            return GetCurrentPlayer.next;
        }

        


        //private Player[] players;
        //public const int SizeOfQueue = 4;
        //private int CurrentPlayer;

        ////SetCurrentPlayerIndex(0);

        //public Player GetCurrentPlayer()//returns Player at current player index
        //{
        //    return GetPlayerAt(GetCurrentPlayerIndex());
        //}
        //public Player GetNextPlayer()   //increments currentPlayerIndex to the next Player and returns the player at the currentPlayerIndex
        //{
        //    SetCurrentPlayerIndex((GetCurrentPlayerIndex() + 1) % SizeOfQueue);

        //    return GetCurrentPlayer();
        //}

        //public Player[] GetQueue()
        //{
        //    return players;
        //}
        //public void SetCurrentPlayerIndex(int input)
        //{
        //    CurrentPlayer = input;
        //}

        //public int GetCurrentPlayerIndex()
        //{
        //    return CurrentPlayer;
        //}

        //public Player GetPlayerAt(int position)
        //{
        //    return players[position];
        //}
    }
}