public class MiArbol{
    public MiNodo raiz;

    //TODO: Programar inserción
    //TODO: Progamar borrado de un nodo
    
    
    public bool BuscarRecursivo(MiNodo nodo, string valor){
        int comparador = String.CompareOrdinal(valor, nodo.Value);
        if(nodo == null){
            return false;
        }
        if(valor == nodo.Value){ //if(comparador == 0)
            return true;
        //}else if(valor < nodo.Value){
        } else if(comparador<0){
            return BuscarRecursivo(nodo.NodoIzquierdo, valor);
        }else{
            return BuscarRecursivo(nodo.NodoDerecho, valor);
        }
    }
}