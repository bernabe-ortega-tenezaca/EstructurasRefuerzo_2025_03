Console.WriteLine("Universidad Estatal Amazónica"); //Console.Writeline sirve para escribir textos en pantalla
Console.WriteLine("=============================="); //Llamar al método Writeline de la clase Console.

GrafoLista g = new GrafoLista(4); //diapositiva 7
g.AddAristaGL(0,1);
g.AddAristaGL(0,2);
g.AddAristaGL(3,2);
g.AddAristaGL(2,4);
// g.PrintGraph();
// System.Console.WriteLine("==============================");\
System.Console.WriteLine(g.PrintGraph(imprimir: true));


GrafoMatriz h = new GrafoMatriz(4);
h.AddEdge(0,1);
h.AddEdge(0,2);
h.AddEdge(1,2);
h.AddEdge(2,3);
h.AddEdge(3,1);
h.PrintGrafo();


GrafoPonderado grafo = new GrafoPonderado(5);
        grafo.AddEdge(0, 1, 10);
        grafo.AddEdge(0, 4, 5);
        grafo.AddEdge(1, 2, 1);
        grafo.AddEdge(1, 4, 2);
        grafo.AddEdge(2, 3, 4);
        grafo.AddEdge(3, 2, 6);
        grafo.AddEdge(4, 1, 3);
        grafo.AddEdge(4, 2, 9);
        grafo.AddEdge(4, 3, 2);

        Console.WriteLine("Grafo de ciudades:");
        grafo.PrintGraph();

        var caminoCorto = grafo.Dijkstra(0);

        
        foreach (var path in caminoCorto)
        {
            Console.WriteLine($"Ciudad {path.Key}: {path.Value}");
        }