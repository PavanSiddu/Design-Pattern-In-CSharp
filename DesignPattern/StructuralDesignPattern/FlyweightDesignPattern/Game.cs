using System;
using System.Collections.Generic;

namespace DesignPattern.StructuralDesignPattern.FlyweightDesignPattern
{
    public class Game
    {
        private readonly List<Tree> trees;
        private readonly List<TreePosition> treePositions;
        private readonly TreeFactory treeFactory;

        public Game()
        {
            this.trees = new List<Tree>();
            this.treePositions = new List<TreePosition>();
            this.treeFactory = new TreeFactory();
        }

        public void AddTree(int x, int y, string color)
        {
            Tree tree = treeFactory.GetTree(color);

            if (tree == null) return;

            trees.Add(tree);
            treePositions.Add(new TreePosition(x, y));

            int treeId = trees.Count - 1;
            this.RenderTree(treeId);
        }

        private void RenderTree(int id)
        {
            Console.WriteLine("Tree " + id
                    + " with " + trees[id].GetColor() + " color"
                    + " rendered at " + treePositions[id].GetX()
                    + ", " + treePositions[id].GetY());
        }

    }
}
