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
}