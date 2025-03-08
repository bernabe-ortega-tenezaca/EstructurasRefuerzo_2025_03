Console.WriteLine("Universidad Estatal Amazónica"); //Console.Writeline sirve para escribir textos en pantalla
System.Console.WriteLine("=============================="); //Llamar al método Writeline de la clase Console.
//Diccionarios1.run();

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