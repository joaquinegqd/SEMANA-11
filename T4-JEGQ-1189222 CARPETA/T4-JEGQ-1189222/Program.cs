// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] billetes = new int[6];

// 100, 50, 20, 10, 5 y 1
billetes[0] = 100;
billetes[1] = 50;
billetes[2] = 20;
billetes[3] = 10;
billetes[4] = 5;
billetes[5] = 1;

Console.Write("Ingrese una cantidad: Q");
int cantidad = int.Parse(Console.ReadLine());

for (int i = 0; i < billetes.Length; i++)
{
    int x = cantidad / billetes[i];
    cantidad = cantidad % billetes[i];
    Console.WriteLine("Q" + billetes[i] + "=" + x);
}