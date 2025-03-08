public static class Diccionarios2{
    public static void run(){
        Dictionary<int, string> jugadores = new Dictionary<int, string>();

        jugadores.Add(1, "Manchester");
        jugadores.Add(2, "Juventus");
        jugadores.Add(3, "Milan");

        foreach (var item in jugadores)
        {
            System.Console.WriteLine(item.Key);
            System.Console.WriteLine(item.Value);
            System.Console.WriteLine(); //Salto de linea
        }
    }
}