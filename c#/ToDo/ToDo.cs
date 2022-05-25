using System;
using System.Collections.Generic;

namespace ToDo
{
    public class ToDo
    {
        private List<CardModel> Card;
        
        public ToDo()
        {
            Card = new List<CardModel>();
        }

        public List<CardModel> Liste()
        {
            return Card;
        }

        public void Add(string baslik, string içerik, string kartsahibi, string büyüklük)
        {
            CardModel cardModel = new CardModel();
            cardModel.Baslik1 = baslik;
            cardModel.İçerik1 = içerik;
            cardModel.KartSahibi1 = kartsahibi;
            cardModel.Büyüklük1 = büyüklük;
            Card.Add(cardModel);
        }

        public void Delete(CardModel cardModel)
        {
            Card.Remove(cardModel);
        }

        public List<CardModel> Find(string baslik, string içerik, string kartsahibi, string büyüklük)
        {
            List<CardModel> result = new List<CardModel>();

            foreach (var item in Card)
            {
                if(item.Baslik1 == baslik || item.İçerik1 == içerik || item.KartSahibi1 == kartsahibi || item.Büyüklük1 == büyüklük)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}