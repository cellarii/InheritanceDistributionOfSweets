using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDistributionOfSweets
{
    public class Sweet
    {
        public double weight;

    }

    public enum ChocholateType { dark, milky, white};
    public class Chocholate : Sweet
    {
        public ChocholateType type;
        public int numberTiles;
    }

    public enum PastriesType { bun, pie, puffPastry };

    public class Pastries : Sweet
    {
        public PastriesType type;
        public int calorie;
    }

    public enum FruitType { tropical, citrus};

    public class Fruit : Sweet
    {
        public FruitType type;
        public int ripeness;
    }
}