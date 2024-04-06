using Clase__9.Clases;
int op;

carro carro = new carro("Toyota", 2017, "Negro");
carro carro2 = new carro("Nissan", 2021, "Rojo");
carro.dueño = "Mario";
carro.velmax= 180;

Console.WriteLine("¿Desea encender el carro?\n1.Si\n0.No");
int.TryParse(Console.ReadLine(), out op);
carro.Encender(op);


Console.WriteLine(carro.aceleracion() + " Km/H");
Console.WriteLine(carro.aceleracion() + " Km/H");
Console.WriteLine(carro.aceleracion() + " Km/H");


Console.WriteLine($"El carro es de marca {carro.marca}");
Console.ReadLine();

Console.WriteLine($"El segundo carro es de marca {carro2.marca}");
Console.ReadLine();