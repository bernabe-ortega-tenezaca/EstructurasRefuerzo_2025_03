public class MiNodo{
    public string Value;
    public MiNodo NodoIzquierdo;
    public MiNodo NodoDerecho;

    public MiNodo(string dato){
        Value = dato;
        NodoIzquierdo = null;
        NodoDerecho = null;
    }
}