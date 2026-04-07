using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDistributionOfSweets
{
    public abstract class Sweet
    {
        public double weight;
        public string name;
        public static Random rnd = new Random();

        public virtual string getInfo()
        {
            return string.Format("\nВес: {0}", weight);
        }

        public abstract string getName();
    }

    public enum ChocholateType { dark, milky, white};
    public class Chocolate : Sweet
    {
        public ChocholateType type;
        public int numberTiles;

        public static  Chocolate Generate()
        {
            return new Chocolate
            {
                name = "Шоколадка",
                weight = rnd.Next(50, 500),
                type = (ChocholateType)rnd.Next(3),
                numberTiles = (int)rnd.Next(2, 20)
            };
        }

        public override string getInfo()
        {
            var strInfo = name;
            strInfo += base.getInfo();
            strInfo += string.Format("\nТип шоколадки: {0}\nКоличество плиток: {1}", type, numberTiles);
            return strInfo;
        }

        public override string getName()
        {
            return name;
        }
    }

    public enum PastriesType { bun, pie, puffPastry };

    public class Pastries : Sweet
    {
        public PastriesType type;
        public int calorie;

        public static Pastries Generate()
        {
            return new Pastries
            {
                name = "Выпечка",
                weight = rnd.Next(50, 500),
                type = (PastriesType)rnd.Next(3),
                calorie = (int)rnd.Next(50, 2000)
            };
        }

        public override string getInfo()
        {
            var strInfo = name;
            strInfo += base.getInfo();
            strInfo += string.Format("\nТип выпечки: {0}\nКалории: {1}", type, calorie);
            return strInfo;
        }

        public override string getName()
        {
            return name;
        }
    }

    public enum creamType { chocolate, custard, cream, curd };

    public class Cake : Sweet
    {
        public int numberLayers;
        public creamType creame;

        public static Cake Generate()
        {
            return new Cake
            {
                name = "Тортик",
                weight = rnd.Next(500, 10000),
                numberLayers = rnd.Next(1, 10),
                creame = (creamType)rnd.Next(4)
            };
        }

        public override string getInfo()
        {
            var strInfo = name;
            strInfo += base.getInfo();
            strInfo += string.Format("\nКоличество слоев: {0}\nКрем: {1}", numberLayers, creame);
            return strInfo;
        }

        public override string getName()
        {
            return name;
        }
    }
}