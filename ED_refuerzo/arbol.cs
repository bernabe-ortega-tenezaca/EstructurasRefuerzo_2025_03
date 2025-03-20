public class Arbol{
    public Nodo raiz;

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
    public void PreOrder(Nodo nodo){
        if(nodo != null){
            System.Console.WriteLine(nodo.Valor + " ");
            PreOrder(nodo.izquierdo);
            PreOrder(nodo.derecho);
        }
    }

    public void InOrder(Nodo nodo){
        if(nodo != null){
            InOrder(nodo.izquierdo);
            System.Console.WriteLine(nodo.Valor + " ");
            InOrder(nodo.derecho);
        }
    }

    public void PosOrder(Nodo nodo){
        if(nodo != null){
            PosOrder(nodo.izquierdo);
            PosOrder(nodo.derecho);
            System.Console.WriteLine(nodo.Valor + " ");
        }
    }


    //TODO: contar
    //TODO: getNivelMaximo
    //TODO: getNoHojas
}