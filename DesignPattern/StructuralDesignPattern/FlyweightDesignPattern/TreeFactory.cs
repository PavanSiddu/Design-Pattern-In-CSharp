using System;
using System.Collections.Generic;

namespace DesignPattern.StructuralDesignPattern.FlyweightDesignPattern
{
    public class TreeFactory
    {
        private static Dictionary<string, Tree> TreeMap;
        public TreeFactory()
        {
            TreeMap = new Dictionary<string, Tree>();
        }
        public Tree GetTree(string color)
        {
            if (color == null) return null;

            if (!color.Equals("green") && !color.Equals("brown")) return null;

            if (TreeMap.ContainsKey(color))
            {
                return TreeMap[color];
            }

            Tree tree = new Tree(color);
            TreeMap.Add(color, tree);
            return tree;
        }
    }
}
