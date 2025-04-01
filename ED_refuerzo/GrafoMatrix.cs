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
}