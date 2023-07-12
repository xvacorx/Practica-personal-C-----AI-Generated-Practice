//2. Ingresar por pantalla los nombres de 5 personas y almacenarlos en un arreglo.
//Luego, mostrar los nombres en orden inverso al ingresado.

string[] Nombres = new string [5];

Console.WriteLine("Ingrese 5 nombres:");

for  (int i = 0; i < Nombres.Length; i++)
{
    Nombres[i] = Console.ReadLine();
}

Console.WriteLine("Mostrar nombres en orden inverso:");
Console.ReadLine();

for  (int i = Nombres.Length - 1; i > -1; i--)
{
    Console.WriteLine(Nombres[i]);
}
