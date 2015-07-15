using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneJSONReaderData
{
    public class Rootobject
    {
        public Basic[] Basic { get; set; }
        public BlackrockMountain[] BlackrockMountain { get; set; }
        public Classic[] Classic { get; set; }
        public Credit[] Credits { get; set; }
        public CurseOfNaxxrama[] CurseofNaxxramas { get; set; }
        public Debug[] Debug { get; set; }
        public GoblinsVsGnome[] GoblinsvsGnomes { get; set; }
        public HeroSkin[] HeroSkins { get; set; }
        public Mission[] Missions { get; set; }
        public Promotion[] Promotion { get; set; }
        public Reward[] Reward { get; set; }
        public System[] System { get; set; }
        public TavernBrawl[] TavernBrawl { get; set; }
    }

    public class Basic
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string text { get; set; }
        public string faction { get; set; }
        public string rarity { get; set; }
        public int cost { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public string flavor { get; set; }
        public string artist { get; set; }
        public bool collectible { get; set; }
        public string howToGetGold { get; set; }
        public string[] mechanics { get; set; }
        public string playerClass { get; set; }
        public string howToGet { get; set; }
        public int durability { get; set; }
        public string race { get; set; }
        public string inPlayText { get; set; }
    }

    public class BlackrockMountain
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int cost { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public string text { get; set; }
        public string[] mechanics { get; set; }
        public string rarity { get; set; }
        public bool elite { get; set; }
        public string race { get; set; }
        public string flavor { get; set; }
        public string artist { get; set; }
        public bool collectible { get; set; }
        public string playerClass { get; set; }
        public string howToGet { get; set; }
        public string howToGetGold { get; set; }
        public string faction { get; set; }
        public int durability { get; set; }
    }

    public class Classic
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string text { get; set; }
        public string[] mechanics { get; set; }
        public string faction { get; set; }
        public string rarity { get; set; }
        public int cost { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public string flavor { get; set; }
        public string artist { get; set; }
        public bool collectible { get; set; }
        public bool elite { get; set; }
        public string playerClass { get; set; }
        public string race { get; set; }
        public string inPlayText { get; set; }
        public int durability { get; set; }
    }

    public class Credit
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public int cost { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public string text { get; set; }
        public bool elite { get; set; }
        public string playerClass { get; set; }
    }

    public class CurseOfNaxxrama
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int health { get; set; }
        public string rarity { get; set; }
        public int cost { get; set; }
        public int attack { get; set; }
        public string text { get; set; }
        public string flavor { get; set; }
        public string artist { get; set; }
        public bool collectible { get; set; }
        public string playerClass { get; set; }
        public string howToGet { get; set; }
        public string howToGetGold { get; set; }
        public string[] mechanics { get; set; }
        public bool elite { get; set; }
        public int durability { get; set; }
        public string race { get; set; }
    }

    public class Debug
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public int cost { get; set; }
        public string text { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public int durability { get; set; }
        public bool elite { get; set; }
        public string[] mechanics { get; set; }
        public string playerClass { get; set; }
    }

    public class GoblinsVsGnome
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public int cost { get; set; }
        public string text { get; set; }
        public string flavor { get; set; }
        public string artist { get; set; }
        public bool collectible { get; set; }
        public string playerClass { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public string race { get; set; }
        public string[] mechanics { get; set; }
        public bool elite { get; set; }
        public int durability { get; set; }
    }

    public class HeroSkin
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public int health { get; set; }
        public bool collectible { get; set; }
        public string playerClass { get; set; }
        public int cost { get; set; }
        public string text { get; set; }
    }

    public class Mission
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string text { get; set; }
        public string faction { get; set; }
        public string rarity { get; set; }
        public int cost { get; set; }
        public int health { get; set; }
        public string inPlayText { get; set; }
        public string[] mechanics { get; set; }
        public int attack { get; set; }
        public int durability { get; set; }
        public string playerClass { get; set; }
    }

    public class Promotion
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int cost { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public string text { get; set; }
        public string race { get; set; }
        public string rarity { get; set; }
        public string flavor { get; set; }
        public string artist { get; set; }
        public bool collectible { get; set; }
        public bool elite { get; set; }
        public string howToGetGold { get; set; }
        public string[] mechanics { get; set; }
        public string faction { get; set; }
        public string inPlayText { get; set; }
    }

    public class Reward
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public int cost { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public string text { get; set; }
        public string flavor { get; set; }
        public string artist { get; set; }
        public bool collectible { get; set; }
        public string race { get; set; }
        public string howToGet { get; set; }
        public string howToGetGold { get; set; }
        public string[] mechanics { get; set; }
        public string faction { get; set; }
        public string inPlayText { get; set; }
        public bool elite { get; set; }
    }

    public class System
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string faction { get; set; }
        public string rarity { get; set; }
        public int cost { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public string text { get; set; }
        public string playerClass { get; set; }
    }

    public class TavernBrawl
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string rarity { get; set; }
        public int cost { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public string text { get; set; }
        public bool elite { get; set; }
        public string race { get; set; }
        public bool collectible { get; set; }
        public string[] mechanics { get; set; }
        public int durability { get; set; }
    }

}
