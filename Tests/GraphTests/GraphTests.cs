using Graph.AdjancencySet;

namespace GraphTests;

public class GraphTests
{
    [Fact]
    public void Graph_Smoke_Test()
    {
        var graph = new Graph<int>();

        graph.AddVertex(1);
        graph.AddVertex(2);
        graph.AddVertex(3);
        graph.AddVertex(4);
        graph.AddVertex(5);

        graph.AddEdge(1, 2);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);
        graph.AddEdge(4, 1);
        graph.AddEdge(3, 5);

        Assert.Equal(3, graph.Edges(4).Count());

        Assert.Equal(5, graph.Count);

        Assert.True(graph.HasEdge(1, 2));

        graph.RemoveEdge(1, 2);

        Assert.False(graph.HasEdge(1, 2));

        graph.RemoveEdge(2, 3);
        graph.RemoveEdge(3, 4);
        graph.RemoveEdge(4, 5);
        graph.RemoveEdge(4, 1);


        Assert.True(graph.HasEdge(3, 5));
        graph.RemoveEdge(3, 5);
        Assert.False(graph.HasEdge(3, 5));

        graph.RemoveVertex(1);
        graph.RemoveVertex(2);
        graph.RemoveVertex(3);
        graph.RemoveVertex(4);

        graph.AddEdge(5, 5);
        graph.RemoveEdge(5, 5);
        graph.RemoveVertex(5);

        Assert.Equal(0, graph.Count);
    }
}

public class WeightedDiGraph_Tests
{
    /// <summary>
    /// key value dictionary tests 
    /// </summary>
    [Fact]
    public void WeightedDiGraph_Smoke_Test()
    {
        var graph = new WeightedDiGraph<int, int>();

        graph.AddVertex(1);
        graph.AddVertex(2);
        graph.AddVertex(3);
        graph.AddVertex(4);
        graph.AddVertex(5);

        graph.AddEdge(1, 2, 1);
        graph.AddEdge(2, 3, 2);
        graph.AddEdge(3, 4, 3);
        graph.AddEdge(4, 5, 1);
        graph.AddEdge(4, 1, 6);
        graph.AddEdge(3, 5, 4);

        

        Assert.Equal(5, graph.Count);

        Assert.True(graph.HasEdge(1, 2));

        graph.RemoveEdge(1, 2);

        Assert.False(graph.HasEdge(1, 2));

        graph.RemoveEdge(2, 3);
        graph.RemoveEdge(3, 4);
        graph.RemoveEdge(4, 5);
        graph.RemoveEdge(4, 1);

        Assert.True(graph.HasEdge(3, 5));
        graph.RemoveEdge(3, 5);
        Assert.False(graph.HasEdge(3, 5));

        graph.RemoveVertex(1);
        graph.RemoveVertex(2);
        graph.RemoveVertex(3);
        graph.RemoveVertex(4);
        graph.RemoveVertex(5);

        Assert.Equal(0, graph.Count);
    }
}
