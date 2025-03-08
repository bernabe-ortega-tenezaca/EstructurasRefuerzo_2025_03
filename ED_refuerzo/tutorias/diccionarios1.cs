public static class Diccionarios1{
    public static void run(){
        System.Console.WriteLine();
        System.Console.WriteLine("---------------------------");
        System.Console.WriteLine("Explicación de diccionarios");
        System.Console.WriteLine("---------------------------");
        System.Console.WriteLine();
        // string estudiante = "Carlos Muñoz";
        // System.Console.WriteLine("Bienvenido " + estudiante + ", estas en tu casa " + estudiante);
        // System.Console.WriteLine("Bienvenido {0}, estas en tu casa {1}", estudiante, estudiante);
        // System.Console.WriteLine($"Bienvenido {estudiante}, estas en tu casa {estudiante}");

        //Estructura clave valor (la clave debe ser única) key value

        List<string> listado = new List<string>();
        LinkedList<string> alumnos = new LinkedList<string>();

        Dictionary<string, string> ciudadanos = new Dictionary<string, string>();
        // Agregamos ciudadanos
        ciudadanos.Add("123456","Jorge");
        ciudadanos.Add("135790", "Anita");
        ciudadanos.Add("135792", "Juanita");

        string textoBuscar = "1234567";
        // Buscar una clave(key) dentro del diccionario
        if (ciudadanos.ContainsKey(textoBuscar))
        {
            System.Console.WriteLine("Encontrado " + ciudadanos[textoBuscar]);
        } else{
            System.Console.WriteLine("NO existe");
        }

        // Recorrer una collection
        foreach (var item in ciudadanos)
        {
            System.Console.WriteLine(item);
        }
    }
}