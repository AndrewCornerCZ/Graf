class Edge
{
    public int Source, Destination, Weight;
    public Edge(int source, int destination, int weight)
    {
        Source = source;
        Destination = destination;
        Weight = weight;
    }
}

class Dijkstra
{
    public static void FindShortestPaths(List<Edge> edges, int vertexCount, int start)
    {
        var graph = new Dictionary<int, List<(int, int)>>();

        // Vytvoření sousedního seznamu
        foreach (var edge in edges)
        {
            if (!graph.ContainsKey(edge.Source))
                graph[edge.Source] = new List<(int, int)>();
            graph[edge.Source].Add((edge.Destination, edge.Weight));
        }

        var distances = new int[vertexCount];
        for (int i = 0; i < vertexCount; i++) distances[i] = int.MaxValue;
        distances[start] = 0;

        var visited = new bool[vertexCount];
        var queue = new PriorityQueue<int, int>();
        queue.Enqueue(start, 0);

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();
            if (visited[current]) continue;
            visited[current] = true;

            if (!graph.ContainsKey(current)) continue;

            foreach (var (neighbor, weight) in graph[current])
            {
                int newDist = distances[current] + weight;
                if (newDist < distances[neighbor])
                {
                    distances[neighbor] = newDist;
                    queue.Enqueue(neighbor, newDist);
                }
            }
        }

        // Výpis výsledků
        for (int i = 0; i < vertexCount; i++)
        {
            Console.WriteLine($"Vzdálenost z vrcholu {start} do {i}: {(distances[i] == int.MaxValue ? "∞" : distances[i])}");
        }
    }

    static void Main()
    {
        var edges = new List<Edge> {
            new Edge(0, 1, 10),
            new Edge(0, 2, 3),
            new Edge(1, 3, 2),
            new Edge(1, 4, 8),
            new Edge(2, 4, 3),
            new Edge(4, 3, 4),
            new Edge(4, 5, 1),
            new Edge(5, 3, 4)
        };

        int vertexCount = 6; // počet vrcholů v grafu
        int startVertex = 0;
        FindShortestPaths(edges, vertexCount, startVertex);
    }
}
