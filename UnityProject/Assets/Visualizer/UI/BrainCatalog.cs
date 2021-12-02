using System;
using System.Collections.Generic;
using System.Linq;
using Visualizer.AgentBrains.EvilBrains;
using Visualizer.AgentBrains.GoodBrains;

namespace Visualizer.UI
{
    public static class BrainCatalog
    {
        // good enough for now at least
        private static readonly Dictionary<string, Type> GoodAlgorithms = new Dictionary<string, Type>()
        {
            {"TSP-Nearest Neighbor" , typeof(TspNearestNeighborFullVisibility)},
            {"TSP-Simulated Annealing" , typeof(TspSimulatedAnnealingFullVisibility)},
            {"BFS-LD-Partial Visibility" , typeof(DfsPartialVisibility)},
            {"Dfs-No Visibility" , typeof(DfsNoVisibility)},
            {"Unobservable BFS", typeof(LevelTraversal)},
        };

        private static readonly Dictionary<string, Type> EvilAlgorithms = new Dictionary<string, Type>()
        {
            {"BFS-Stain Closest", typeof(BfsStainClosestTileFullVisibility)},
        };

        public static List<string> GetAllGoodBrainNames()
        {
            return GoodAlgorithms.Keys.ToList();
        }

        public static List<string> GetAllEvilBrainNames()
        {
            return EvilAlgorithms.Keys.ToList();
        }
        
        public static Type GetGoodBrain (string name)
        {
            return GoodAlgorithms[name];
        }

        public static Type GetEvilBrain(string name)
        {
            return EvilAlgorithms[name];
        }
    }
}