int x;
Console.WriteLine("Nhap vao 1 so bat ky: ");
x = int.Parse(Console.ReadLine()?? "0");
if (x % 2 == 0)
{
    Console.WriteLine($"{x} la so chan!");
}
else
{
    Console.WriteLine($"{x} la so le!");
}