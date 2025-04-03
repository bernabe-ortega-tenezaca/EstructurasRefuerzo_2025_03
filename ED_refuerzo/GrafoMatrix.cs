public class GrafoMatriz{

    private int[,] adjMatrix; //Matriz de adyacencia es de VxV

    //Constructor
    public GrafoMatriz(int vertices){
        adjMatrix = new int[vertices, vertices];//inicialización
    }

    // 0 es ausencia y 1 presencia
    // ponderada -> peso, o nulo para indicar ausencia
    public void AddEdge(int v, int w){
        adjMatrix[v,w] = 1; //indica presencia
    }

    public void PrintGrafo(){
        int vertices = adjMatrix.GetLength(0);

        for (int i = 0; i < vertices; i++)
        {
            for (int j = 0; j < vertices; j++)
            {
                System.Console.Write($"{adjMatrix[i,j]} ");
            }
            System.Console.WriteLine();
        }
    }
}