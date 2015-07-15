using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneJSONReader
{
    class CardData
    {
        public string name { get; set; }
        public int cost { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public string faction { get; set; }
        public string text { get; set; }
        public string[] mechanics { get; set; }
        public string flavor { get; set; }
        public string artist { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public bool collectible { get; set; }
        public string id { get; set; }
        public bool elite { get; set; }
    }
}
