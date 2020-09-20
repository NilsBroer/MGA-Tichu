using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Utilities;
using T = Entities.CardEnums.Tichu;

namespace Entities
{
    public class Deck : IDeck
    {
        List<Card> Cards = new List<Card>();
        
        public Deck()
        {
            var sonder = new List<string>()
            {
                T.Names.Dog.ToString(),
                T.Names.Mahjong.ToString(),
                T.Names.Phoenix.ToString(),
                T.Names.Dragon.ToString()
            };

            foreach (var name in CardFeatures.Names.Where(name => !sonder.Contains(name)))
            {
                CardFeatures.Values.TryGetValue(name, out var value);
                CardFeatures.Points.TryGetValue(name, out var points);
                foreach (var suit in CardFeatures.Suits)
                {
                    Cards.Add(new Card(name,value,suit,points));
                }
            }
            foreach (var name in sonder)
            {
                CardFeatures.Values.TryGetValue(name, out var value);
                CardFeatures.Points.TryGetValue(name, out var points);
                Cards.Add(new Card(name,value,null,points));
            }
        }
        
        public void Shuffle()
        {
            Cards.Randomize();
            foreach (var card in Cards)
            {
                Debug.Log((card.Suit != null ? card.Suit + " " : "") + card.Name);
            }
        }
    }
}