//10. Escribe un programa en C# que le pida al usuario que ingrese un número y calcule su factorial.

Console.WriteLine("Ingrese un número:");
int numero = int.Parse(Console.ReadLine());

int factorial = 1;

for (int i = 1; i <= numero; i++)
{
    factorial *= i; //se van recorriendo los números 1 a 1 hasta llegar al solicitado. Multiplicando cada uno y añadiendolo a "factorial"
}

Console.WriteLine("El factorial de " + numero + " es: " + factorial);
