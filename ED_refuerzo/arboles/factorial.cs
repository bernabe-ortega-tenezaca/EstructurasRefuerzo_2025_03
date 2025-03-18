public static class Factorial{
    public static void run(){
        //n! = n*(n-1)!
        static int Factorial(int n){ //FUNCION RECURSIVA
            if(n == 1)
                return 1;
            
            return n * Factorial(n-1);
        } 

        int a = 5;
        System.Console.WriteLine($"factorial de {a} es {Factorial(a)}");

        static int Factorial1(int n){ //FUNCION ITERACTIVA
            int respuesta = 1;
            int aux = n;
            while(aux >1){
                respuesta = respuesta * aux;
                aux = aux - 1;
            }
            return respuesta;
        }


        System.Console.WriteLine($"factorial de {a} es {Factorial1(a)}");
    }
}