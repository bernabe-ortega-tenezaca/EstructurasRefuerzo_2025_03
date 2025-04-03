Console.WriteLine("Universidad Estatal Amazónica"); //Console.Writeline sirve para escribir textos en pantalla
Console.WriteLine("=============================="); //Llamar al método Writeline de la clase Console.

GrafoLista g = new GrafoLista(4); //diapositiva 7
g.AddAristaGL(0,1);
g.AddAristaGL(0,2);
g.AddAristaGL(3,2);
g.AddAristaGL(2,4);
g.PrintGraph();
System.Console.WriteLine("==============================");

GrafoMatriz h = new GrafoMatriz(4);
h.AddEdge(0,1);
h.AddEdge(0,2);
h.AddEdge(1,2);
h.AddEdge(2,3);
h.AddEdge(3,1);
h.PrintGrafo();


GrafoPonderado p = new GrafoPonderado(4);
p.AddEdge(0,1,20);
p.AddEdge(0,2,50);