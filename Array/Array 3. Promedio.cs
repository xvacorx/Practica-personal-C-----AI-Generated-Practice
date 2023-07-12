//3. Calcular el promedio de un arreglo de calificaciones (números decimales) e imprimir el resultado.

Console.WriteLine("ingrese cantidad de alumnos:");

int Cantidad = int.Parse(Console.ReadLine());

float[] Calificaciones =  new float[Cantidad];
float Total = 0;

Console.WriteLine("Ingrese las notas de los {0} alumnos", Cantidad);

for (int i = 0; i < Cantidad; i++)
{
    Calificaciones[i] = float.Parse(Console.ReadLine());
    Total += Calificaciones[i];
}

float Promedio = Total / Cantidad;

Console.WriteLine("El promedio es de " + Promedio);
