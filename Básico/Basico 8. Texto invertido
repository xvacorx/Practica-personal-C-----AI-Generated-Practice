//8. Escribe un programa en C# que le pida al usuario que ingrese una cadena de texto y la imprima al revés.

Console.WriteLine("Ingrese un texto:");
string Texto = Console.ReadLine();

string TextoInvertido = ""; //Se necesita inicializar la variable fuera del for. se utiliza un espacio para que esté "vacía"

for (int i = Texto.Length - 1; i >= 0; i--) //La primer letra del texto es la ubicación 0, por lo que al usar la funcion .Length se le resta 1 para ajustar la posición
{
    TextoInvertido += Texto[i]; //Se van asignando las letras una tras otra, guiandose por la posición i
}

Console.WriteLine("El texto invertido es: ");
Console.WriteLine(TextoInvertido);
