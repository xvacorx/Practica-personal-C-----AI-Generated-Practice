//2. Escribe un programa en C# que calcule la suma de dos números ingresados por el usuario.

Console.WriteLine("Ingrese un número");
int N1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese otro número");
int N2 = int.Parse(Console.ReadLine());

int Suma = N1 + N2;

Console.WriteLine("La suma entre ambos números es de: " + Suma);
