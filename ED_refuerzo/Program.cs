Console.WriteLine("Universidad Estatal Amazónica"); //Console.Writeline sirve para escribir textos en pantalla
Console.WriteLine("=============================="); //Llamar al método Writeline de la clase Console.

Arbol Equipos = new Arbol();

Equipos.Insertar("5");
Equipos.Insertar("3");
Equipos.Insertar("7");
Equipos.Insertar("2");
Equipos.Insertar("4");
Equipos.Insertar("9");

Equipos.PosOrder(Equipos.raiz);
System.Console.WriteLine();
Equipos.InOrder(Equipos.raiz);
System.Console.WriteLine();
Equipos.ImprimirPreorder(); //linea mejorada
System.Console.WriteLine();
Equipos.PrintTree(Equipos.raiz);
System.Console.WriteLine();
Equipos.PrintSearchPath(Equipos.raiz, "9");





































//Diccionarios1.run();
//Diccionarios2.run();

// string a = "El viejo y el mar";
// string b = "El viejo y el mar";

// int valor = a.CompareTo(b);

// if(a.CompareTo(b)==0){
//     System.Console.WriteLine("es igual");
// }else{
//     System.Console.WriteLine("no es igual");
// }

// ArbolbinarioBusqueda misEstudiantes = new ArbolbinarioBusqueda();
// // juan, ana, antonio, juanita, pepe, lucia
// misEstudiantes.insertarEstudiante("Juan"); // Juan se convierte en la raíz
// misEstudiantes.insertarEstudiante("Anita");
// misEstudiantes.insertarEstudiante("Antonio");

// bool encontrado = misEstudiantes.Buscar("juan");

// if(encontrado){
//     System.Console.WriteLine("encontrado");
// }else{
//     System.Console.WriteLine("No existe este registro");
// }



