public class ArbolbinarioBusqueda{
    private Nodo raiz; //Root nivel 0

    public void insertarEstudiante(string nombre){
        try
        {
            if (raiz == null){ //diapositiva 7
                //raiz.nombres = nombre;
                raiz = new Nodo(nombre);
            } 
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
    
    //Semana13 lamina
    public bool Buscar(string nombre){
        return BuscarRecursivamente(raiz, nombre);
    }


    //Búsqueda recursiva semana 13 lamina 9
    private bool BuscarRecursivamente(Nodo nodo, string valor){
        if(nodo == null) {
            return false;
        }
        
        //int comparador = string.CompareOrdinal(valor, nodo.nombres);
        int comparador = valor.CompareTo(nodo.nombres);

        if(comparador == 0){
            return true;
        } else if (comparador < 0){
            return BuscarRecursivamente(nodo.izquierdo, valor);
        }else{
            return BuscarRecursivamente(nodo.derecho, valor);
        }
    }
}