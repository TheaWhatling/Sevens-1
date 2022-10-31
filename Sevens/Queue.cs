using System;

namespace Sevens
{
    class Queue
    {
        private PlayerNode front;
        private PlayerNode currentplayer;

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

            currentplayer = pnode1;
        }

        public Player GetCurrentPlayer()
        {
            return currentplayer.p;
        }

        public void MoveOnToNextPlayer()
        {
            currentplayer = currentplayer.next;
        }

        public void addCard(Card c)
        {
            currentplayer.p.AddToHand(c);
            currentplayer = currentplayer.next;
        }

        public void move()
        {
            currentplayer.p.Move();
            MoveOnToNextPlayer();
        }
    }
}