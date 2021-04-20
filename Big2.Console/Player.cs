using System;
using System.Collections.Generic;
using System.Linq;

namespace Big2.Console
{
    public class Player
    {
        public int Num;
        public string Name { get; set; }
        public IList<Card> Cards { get; private set; }
        public void AddCard(Card card)
        {
            if (Cards.Count() < 13) Cards.Add(card);
        }
        public Player(string name)
        {
            Name = name;
        }

        public void HandlePlayResult(Card card, string result)
        {
            throw new NotImplementedException();
        }
    }
}