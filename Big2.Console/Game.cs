using System;
using Big2.Console.Enums;

namespace Big2.Console
{
    public class Game
    {
        public Player CurrentPlayer { get; private set; }
        public Pattern CurrentRoundPattern { get; private set; } = Pattern.Undefined;
        public int CurrentRoundPassesNum { get; private set; }

        public string HandleCard(Card card)
        {
            // match pattern
            // if pattern is Undefined, set pattern
            throw new NotImplementedException();
        }

        public void HandlePass()
        {
            throw new NotImplementedException();
        }

        public void ResetRoundIfNeeded()
        {
            if (CurrentRoundPassesNum > 3)
            {
                CurrentRoundPattern = Pattern.Undefined;
                CurrentRoundPassesNum = 0;
            }
        }

        public void UpdateCurrentPlayer(Player player)
        {
            throw new NotImplementedException();
        }
    }
}