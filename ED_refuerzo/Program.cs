Console.WriteLine("Universidad Estatal Amazónica"); //Console.Writeline sirve para escribir textos en pantalla
Console.WriteLine("=============================="); //Llamar al método Writeline de la clase Console.

GrafoLista g = new GrafoLista(6); //diapositiva 7
g.AddAristaGL(0,1);
g.AddAristaGL(0,2);

GrafoMatriz h = new GrafoMatriz(4);
h.AddEdge(0,1);
h.AddEdge(0,2);

// for (int i = 0; i < g.getCantidadVertices(); i++)
// {
//     System.Console.WriteLine(g);

// }

System.Console.WriteLine();

// foreach (var item in h)
// {
    
// }