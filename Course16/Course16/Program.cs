using Course16;
using System.Globalization;

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo x: ");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double px = (x.A + x.B + x.C) / 2;
double areaX = Math.Sqrt(px * (px - x.A) * (px - x.B) * (px - x.C));

Console.WriteLine("Entre com as medidas do triângulo y: ");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double py = (y.A + y.B + y.C) / 2;
double areaY = Math.Sqrt(py * (py - y.A) * (py - y.B) * (py - y.C));

Console.WriteLine("Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior área: X");
}
else if (areaY > areaX)
{
    Console.WriteLine("Maior área: Y");
}
else
{
    Console.WriteLine("X e Y possuem áreas iguais");
}