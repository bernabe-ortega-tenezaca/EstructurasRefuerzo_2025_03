public class Arbol{
    public Node raiz; //ver diapositiva 9 semana 13

    //TODO: Método de insercíon de datos
    //TODO: Eliminación de un nodo
    
    public bool Buscar(string valor){
        return BuscarRecursiva( raiz, valor);
    }

    private bool BuscarRecursiva(Node nodo, string valor){
        if(nodo == null){
            return false;
        }

        int evaluar = valor.CompareTo(nodo.Value);

        if(valor == nodo.Value){
            return true;
        }else if(evaluar<0){
            return BuscarRecursiva(nodo.NodoIzq, valor);
        }else{
            return BuscarRecursiva(nodo.NodoDer, valor);
        }
    }

}