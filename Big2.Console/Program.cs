using System;
using System.Collections.Generic;
using System.Linq;

namespace Big2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("A new round begins.");

            Game game = new Game();

            var deckInput = System.Console.ReadLine();
            IList<Card> deck = GetDeckFromInput(deckInput);

            IList<Player> players = CreatePlayers();

            AddCardsToPlayers(deck, players);

            var player = GetFirstPlayer();

            while (!VerifyAnyoneCardsEmpty(players))
            {
                System.Console.WriteLine("Next turn: " + player.Name);
                game.UpdateCurrentPlayer(player);

                PrintPlayerCards(player);

                var playInput = System.Console.ReadLine();
                if (playInput.Contains("-1"))
                {
                    game.HandlePass();
                }
                else
                {
                    Card card = GetCardFromInput(playInput);
                    var result = game.HandleCard(card);

                    player.HandlePlayResult(card, result);
                }

                game.ResetRoundIfNeeded();

                game.UpdateCurrentPlayer(GetNextPlayer(player));

            }

            Player winner = players.Single(x => x.Cards.Count() == 0);

            System.Console.WriteLine("Game over, the winner is " + winner);

        }

        private static bool VerifyAnyoneCardsEmpty(IList<Player> players)
        {
            throw new NotImplementedException();
        }

        private static Player GetNextPlayer(Player player)
        {
            throw new NotImplementedException();
        }

        private static Card GetCardFromInput(string actionInput)
        {
            throw new NotImplementedException();
        }

        private static void PrintPlayerCards(Player player)
        {
            throw new NotImplementedException();
        }

        private static Player GetFirstPlayer()
        {
            throw new NotImplementedException();
        }

        private static void AddCardsToPlayers(IList<Card> card, IList<Player> players)
        {
            throw new NotImplementedException();
        }


        private static IList<Player> CreatePlayers()
        {
            IList<Player> players = new List<Player>();
            for (int i = 0; i < 4; i++)
            {
                var playerInput = System.Console.ReadLine();
                Player player = CreatePlayerFromInput(playerInput);
                player.Num = i;
                players.Add(player);
            }
            return players;
        }


        private static Player CreatePlayerFromInput(string playerInput)
        {
            throw new NotImplementedException();
        }

        private static IList<Card> GetDeckFromInput(string deckInput)
        {
            throw new NotImplementedException();
        }
    }
}
