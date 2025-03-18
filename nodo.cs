public class Nodo {
    public string Valor;
    public Nodo izquierdo;
    public Nodo derecho;

    public Nodo(string value){ //constructor
        Valor = value;
        izquierdo = null;
        derecho = null;
    }
}