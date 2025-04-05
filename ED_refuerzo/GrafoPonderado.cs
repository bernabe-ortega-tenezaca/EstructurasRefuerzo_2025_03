public class GrafoPonderado{

    public int NumeroVertices;
    public List<Tuple<int, int>>[] adj; //Lista de adyacencia

    //Constructor
    public GrafoPonderado(int vertices){
        NumeroVertices = vertices;

        adj = new List<Tuple<int, int>>[NumeroVertices];
        for (int i = 0; i < NumeroVertices; i++)
        {
            adj[i] = new List<Tuple<int, int>>();
        }
    }

    public void AddEdge(int v, int w, int peso){
        adj[v].Add(new Tuple<int, int>(w, peso));
    }

    public void PrintGraph()
    {
        for (int i = 0; i < NumeroVertices; i++)
        {
            Console.Write($"Ciudad {i}: ");
            foreach (var edge in adj[i])
            {
                Console.Write($"-> (Ciudad {edge.Item1}, Precio {edge.Item2}) ");
            }
            Console.WriteLine();
        }
    }

    // Algoritmo de Dijkstra para encontrar el camino más barato
    public Dictionary<int, int> Dijkstra(int startVertex)
    {
        var distances = new Dictionary<int, int>();
        var priorityQueue = new PriorityQueue<(int Distance, int Vertex), int>();
        var visited = new HashSet<int>();

        // Inicializar distancias
        for (int i = 0; i < NumeroVertices; i++)
        {
            distances[i] = int.MaxValue;
        }
        distances[startVertex] = 0;
        priorityQueue.Enqueue((0, startVertex), 0);

        while (priorityQueue.Count > 0)
        {
            var (currentDistance, currentVertex) = priorityQueue.Dequeue();

            if (visited.Contains(currentVertex)) continue;
            visited.Add(currentVertex);

            foreach (var edge in adj[currentVertex])
            {
                int newDistance = currentDistance + edge.Item2;
                if (newDistance < distances[edge.Item1])
                {
                    distances[edge.Item1] = newDistance;
                    priorityQueue.Enqueue((newDistance, edge.Item1), newDistance);
                }
            }
        }

        return distances;
    }
}