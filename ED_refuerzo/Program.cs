Console.WriteLine("Universidad Estatal Amazónica"); //Console.Writeline sirve para escribir textos en pantalla
Console.WriteLine("=============================="); //Llamar al método Writeline de la clase Console.
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

ArbolbinarioBusqueda misEstudiantes = new ArbolbinarioBusqueda();
// juan, ana, antonio, juanita, pepe, lucia
misEstudiantes.insertarEstudiante("Juan"); // Juan se convierte en la raíz
misEstudiantes.insertarEstudiante("Anita");
misEstudiantes.insertarEstudiante("Antonio");

bool encontrado = misEstudiantes.Buscar("juan");

if(encontrado){
    System.Console.WriteLine("encontrado");
}else{
    System.Console.WriteLine("No existe este registro");
}



