//9. Escribe un programa en C# que le pida al usuario que ingrese dos números enteros y los intercambie.

Console.WriteLine("Ingrese el primer número");
int N1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número");
int N2 = int.Parse(Console.ReadLine());

int Aux = N1;

N1 = N2;

N2 = Aux;

Console.WriteLine("Los números intercambiados quedarían de la siguiente forma:");
Console.WriteLine("N1: " + N1 + ", y N2: " +  N2);
