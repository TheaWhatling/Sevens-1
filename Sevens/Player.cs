using System;

namespace Sevens
{
    class Player
    {
        private Hand hand;
        private Table table;

        public Player(Table t)
        {
            hand = new Hand();
            table = t; 
        }

        //takes Card to be added to hand and adds it to the end of the listOfCards
        public void AddToHand(Card newCard)
        {
            hand.addCardToHand(newCard);
        }

        //returns true if player's hand contains the 7 of diamonds
        public Boolean CheckSevenDiamonds() //hearts
        {
            return false;
        }

        //string array of user's cards
        //public String[] GetStringArrayOfCards()
        //{
        //    String[] stringCards = new String[GetCurrentSize()];
        //    for (int i = 0; i < GetCurrentSize(); i++)
        //    {
        //        stringCards[i] = GetCards()[i].suitIntToString() + GetCards()[i].getValue().ToString();
        //    }

        //    return stringCards;
        //}

        public Card Move()
        {
            Card temp = null; ;
            bool laid = false;
            int x = 0;

            if (table.EmptyTable()==true)
            {
                if (hand.SearchHand(2, 6) != -1)
                {
                    temp = hand.GetCard(hand.SearchHand(2, 6));
                     hand.SetCard(null , hand.SearchHand(2, 6));
                     table.Update(temp);
                    
                }
            }
            else
            {
                while (x < 13 && laid == false)
                {
                    temp = hand.GetCard(x);
                    if(table.placecard(temp) == true )
                    {
                        hand.SetCard(null, x);
                        table.Update(temp);
                        laid = true;
                    }
                    x = x + 1;
                }
            }
            if(laid == false) temp = null;
            return temp;
        }

        //public void RemoveCard(Card cardToBeRemoved)
        //{
            
        //}



        //public void SortCards(Boolean bySuit)
        //{
        //    ListOfCards = MergeSort(ListOfCards, bySuit);
        //}



        //public virtual Boolean HandEmpty()
        //{
        //    if (GetCurrentSize() == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public int[] CardsSuitCounts()
        //{
        //    int[] cardCount = new int[4] { 0, 0, 0, 0 };

        //    for (int i = 0; i < GetCurrentSize(); i++)
        //    {
        //        cardCount[GetCards()[i].getSuit()]++;
        //    }

        //    return cardCount;
        //}

        //private static List<Card> MergeSort(List<Card> unsorted, Boolean bySuit)
        //{
        //    if (unsorted.Count <= 1)
        //    {
        //        return unsorted;
        //    }
        //    else
        //    {
        //        List<Card> left = new List<Card>();
        //        List<Card> right = new List<Card>();

        //        int mid = unsorted.Count / 2;
        //        for (int i = 0; i < mid; i++)  //Divide unsorted list
        //        {
        //            left.Add(unsorted.ElementAt(i));
        //        }
        //        for (int i = mid; i < unsorted.Count; i++)
        //        {
        //            right.Add(unsorted.ElementAt(i));
        //        }

        //        left = MergeSort(left, bySuit);
        //        right = MergeSort(right, bySuit);
        //        return Merge(left, right, bySuit);
        //    }
        //}

        //private static List<Card> Merge(List<Card> left, List<Card> right, Boolean bySuit)
        //{
        //    List<Card> mergedList = new List<Card>();

        //    while (left.Count > 0 || right.Count > 0)
        //    {
        //        if (left.Count > 0 && right.Count > 0)
        //        {
        //            if (bySuit)
        //            {
        //                if (CompareBySuit(left, right))  //compares first 2 elements 
        //                {
        //                    mergedList.Add(left.First());
        //                    left.Remove(left.First());
        //                }
        //                else
        //                {
        //                    mergedList.Add(right.First());
        //                    right.Remove(right.First());
        //                }
        //            }
        //            else
        //            {
        //                if (CompareByValue(left, right))  //compares first 2 elements 
        //                {
        //                    mergedList.Add(left.First());
        //                    left.Remove(left.First());
        //                }
        //                else
        //                {
        //                    mergedList.Add(right.First());
        //                    right.Remove(right.First());
        //                }
        //            }
        //        }
        //        else if (left.Count > 0) 
        //        {
        //            mergedList.Add(left.First());
        //            left.Remove(left.First());
        //        }
        //        else if (right.Count > 0) 
        //        {
        //            mergedList.Add(right.First());

        //            right.Remove(right.First());
        //        }
        //    }
        //    return mergedList;
        //}
        //public static Boolean CompareByValue(List<Card> left, List<Card> right)
        //{
        //    return (left.First().getValue() <= right.First().getValue());
        //}

        //public static Boolean CompareBySuit(List<Card> left, List<Card> right)
        //{
        //    return (left.First().getSuit() <= right.First().getSuit());
        //}

        //returns int that = length of listOfCards
        //public virtual int GetCurrentSize()
        //{
        //    return ListOfCards.Count;
        //}

        //public List<Card> GetCards()
        //{
        //    return ListOfCards;
        //}
    }
}