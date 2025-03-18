public class Node{
    public string Value;
    public Node NodoIzq;
    public Node NodoDer;

    public Node(string valor){ //valor viene fuera de la clase
        Value = valor;
        NodoIzq = null;
        NodoDer = null;
    }
}