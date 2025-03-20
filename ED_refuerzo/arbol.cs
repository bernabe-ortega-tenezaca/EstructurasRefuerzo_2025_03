public class Arbol{
    public Nodo raiz;

    //TODO: insertar
    public void Insertar(string value){
        raiz = InsertarRecursivo(raiz, value);
    }

    private Nodo InsertarRecursivo(Nodo raiz, string value){
        if(raiz == null){ //Se ejecuta cuando no hay árbol
            raiz = new Nodo(value);
            return raiz;
        }

        if(string.Compare(value, raiz.Valor) <0){ //En el caso de que haya un árbol
            raiz.izquierdo = InsertarRecursivo(raiz.izquierdo, value);
        }else{
            raiz.derecho = InsertarRecursivo(raiz.derecho, value);
        }
        
        return raiz;
    }


    //TODO: eliminar
    //TODO: buscar
    //TODO: recorrer
    //TODO: contar
    //TODO: getNivelMaximo
    //TODO: getNoHojas
}