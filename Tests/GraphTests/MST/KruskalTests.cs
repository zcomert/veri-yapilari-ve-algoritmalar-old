using Graph.AdjancencySet;
using Graph.MinimumSpanningTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTests.MST
{
    public class KruskalTests
    {
        [Fact]
        public void Krusal_Test()
        {
            var graph = new WeightedGraph<char, int>();

            graph.AddVertex('S');
            graph.AddVertex('A');
            graph.AddVertex('B');
            graph.AddVertex('C');
            graph.AddVertex('D');
            graph.AddVertex('T');

            graph.AddEdge('S', 'A', 8);
            graph.AddEdge('S', 'C', 10);

            graph.AddEdge('A', 'B', 10);
            graph.AddEdge('A', 'C', 1);
            graph.AddEdge('A', 'D', 8);

            graph.AddEdge('B', 'T', 4);

            graph.AddEdge('C', 'D', 1);

            graph.AddEdge('D', 'B', 1);
            graph.AddEdge('D', 'T', 10);

            var algorithm = new Kruskals<char, int>();
            var result = algorithm.FindMinimumSpanningTree(graph);

            Assert.Equal(graph.Count- 1, result.Count);
        }
    }
}
