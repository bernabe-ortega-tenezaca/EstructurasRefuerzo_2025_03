using System.Reflection.Metadata;

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

    public void ImprimirPreorder(){
        PreOrder(raiz);
    }
    private void PreOrder(Nodo nodo){
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

    //ident es una parametro opcional con valor por defecto  espacio
    //last es un parametro opcional con valor por defecto true
    public void PrintTree(Nodo nodo, string ident = " ", bool last = true){
        if(nodo != null){
            System.Console.Write(ident);
            if (last)
            {
                System.Console.Write("└");
                ident += " ";
            }else{
                System.Console.Write("|-");
                ident += "|";
            }
            System.Console.WriteLine(nodo.Valor);
            PrintTree(nodo.izquierdo, ident, false);
            PrintTree(nodo.derecho, ident, true);
        }
    }

    public void PrintSearchPath(Nodo nodo, string value){
        Nodo current = raiz;

        while(current != null){
            System.Console.WriteLine(current.Valor + "->");
            if(string.Compare(value, nodo.Valor)<0){
                current = current.izquierdo;
            }else if(string.Compare(value,nodo.Valor)>0){
                current = current.derecho;
            }else{
                break;
            }
        }

        if(current == null) System.Console.WriteLine("No encontrado");
        else System.Console.WriteLine("Encontrado: " + current.Valor);
    }

}