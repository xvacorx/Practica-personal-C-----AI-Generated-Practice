//6. Escribe un programa en C# que imprima los primeros N números de la serie de Fibonacci, donde N es un número ingresado por el usuario.

Console.WriteLine("Ingrese el número N:");
int n = int.Parse(Console.ReadLine());

int N1 = 0;
int N2 = 1;

Console.WriteLine("Los primeros " + n + " números de la serie de Fibonacci son:");

if (n >= 1)
{
    Console.WriteLine(N1); //si el número es 1, la secuencia sólo mostrará N1 (es decir, 0)
}

if (n >= 2)
{
    Console.WriteLine(N2); //si el número s 2, la secuencia mostrará N1 y N2 (osea, 0, 1)
}

for (int i = 3; i <= n; i++) //aquí es donde la secuencia comienza. Si el número es 3 o mayor, mostrará N1, N2 y luego sumará ambos para mostrar la suma( es decir, N1, N2, Suma)
{
    int suma = N1 + N2;
    Console.WriteLine(suma);

    N1 = N2; //asigna N2 a N1, es decir. El último número a la primer variable
    N2 = suma; //asigna la suma a N2, para que pase a ser el siguiente número en la secuencia
}
