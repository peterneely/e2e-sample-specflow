using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Cards
{
    public abstract class BaseCard
    {
        private IEnumerable<PaymentCard> _cards;
        private PaymentCard _card;

        public IEnumerable<PaymentCard> All
        {
            get { return _cards ?? (_cards = Create()); }
        }

        public PaymentCard Single
        {
            get { return _card ?? (_card = All.FirstOrDefault()); }
        }

        protected abstract IEnumerable<PaymentCard> Create();

        protected IEnumerable<PaymentCard> CreateMultiple(PaymentCard cardTemplate, int max)
        {
            var cards = new List<PaymentCard>();
            Mapper.CreateMap<PaymentCard, PaymentCard>();
            for (var i = 1; i <= max; i++)
            {
                var card = new PaymentCard();
                Mapper.Map(cardTemplate, card);
                card.ExpiryMonth = i;
                card.Name = string.Format("{0} {1}", card.Name, i);
                card.Type = RandomiseCardType(card.Type);
                cards.Add(card);
            }
            return cards;
        }

        private static string RandomiseCardType(string cardType)
        {
            if (cardType == "VISA") return "VISA";
            var random = new Random();
            var typeNum = random.Next(1, 3);
            switch (typeNum)
            {
                case 1:
                    return "MasterCard";
                case 2:
                    return "AmericanExpress";
                case 3:
                    return "Maestro";
                default:
                    return "MasterCard";
            }
        }
    }

    public class PaymentCard
    {
        public string Number { get; set; }
        public string MaskedNumber { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
        public string SecurityNumber { get; set; }
    }

    public class Seed
    {
        public int Valid { get; set; }
        public int Expired { get; set; }
        public int Declined { get; set; }
    }

    public class RandomSeed
    {
        public Range Valid { get; set; }
        public Range Expired { get; set; }
        public Range Declined { get; set; }
    }

    public class Range
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
