using Graph.AdjancencySet;

namespace GraphTests;

public class DiGraph_Tests
{
    /// <summary>
    /// key value dictionary tests 
    /// </summary>
    [Fact]
    public void DiGraph_Smoke_Test()
    {
        var graph = new DiGraph<int>();

        graph.AddVertex(1);
        graph.AddVertex(2);
        graph.AddVertex(3);
        graph.AddVertex(4);
        graph.AddVertex(5);

        graph.AddEdge(1, 2);
        Assert.True(graph.HasEdge(1, 2));
        Assert.True(graph.HasEdge(2, 1));

        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);
        graph.AddEdge(4, 1);
        graph.AddEdge(3, 5);

        //IEnumerable test using linq
        Assert.Equal(graph.Count, graph.Count());

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

        //IEnumerable test using linq
        Assert.Equal(graph.Count, graph.Count());


    }
}

public class WeightedGraph_Tests
{
    /// <summary>
    /// key value dictionary tests 
    /// </summary>
    [Fact]
    public void WeightedGraph_Smoke_Test()
    {
        var graph = new WeightedGraph<int, int>();

        graph.AddVertex(1);
        graph.AddVertex(2);
        graph.AddVertex(3);
        graph.AddVertex(4);
        graph.AddVertex(5);

        graph.AddEdge(1, 2, 1);
        graph.AddEdge(2, 3, 2);
        graph.AddEdge(3, 4, 4);
        graph.AddEdge(4, 5, 5);
        graph.AddEdge(4, 1, 1);
        graph.AddEdge(3, 5, 0);


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