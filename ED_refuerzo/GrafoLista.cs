public class GrafoLista{
    private int V; //cantidad de vértices
    private List<int>[] adj; //lista de adyacencia

    //Constructor
    public GrafoLista(int vertices){
        V = vertices;
        adj = new List<int>[V];

        for (int i = 0; i < V; i++)//una lista de enteros por cada vertice
        {
            adj[i] = new List<int>(); //creamos una lista para cada V
        }
    }

    public void AddAristaGL(int v, int w){
        adj[v].Add(w);
    }

    void BFS(int v){
        Queue<int> queue = new Queue<int>();
        bool[] visitado = new bool[v];

        queue.Enqueue(v);
        visitado[v] = true;

        while (queue.Count > 0)
        {
            int u = queue.Dequeue();

            foreach (int w in adj[u])
            {
                if(!visitado[w]){
                    queue.Enqueue(w);
                    visitado[w]= true;
                }
            }
        }    
    }

    public void PrintGraph(){
        for (int i = 0; i < V; i++)
        {
            System.Console.Write($"Vertice {i}: ");
            foreach (var item in adj[i])
            {
                System.Console.Write($" -> {item}");
            }
            System.Console.WriteLine();
        }
    }

}
