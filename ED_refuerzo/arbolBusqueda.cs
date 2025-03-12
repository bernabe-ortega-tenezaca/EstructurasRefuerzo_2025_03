public class ArbolbinarioBusqueda{
    private Nodo raiz; //Root nivel 0
    
    //Búsqueda recursiva
    private bool BuscarRecursivamente(Nodo nodo, string valor){
        if(nodo == null) {
            return false;
        }

        int comparador = string.CompareOrdinal(valor, nodo.nombres);

        if(comparador == 0){
            return true;
        } else if (comparador != 0){
            return BuscarRecursivamente(nodo.izquierdo, valor);
        }else{
            return BuscarRecursivamente(nodo.derecho, valor);
        }
    }
}