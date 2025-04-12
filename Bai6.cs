int x;
Console.WriteLine("Nhap vao mot so bat ky: ");
x = int.Parse(Console.ReadLine());
if (x > 0)
{
    Console.WriteLine($"{x} la so duong!");
}
else if (x < 0)
{
    Console.WriteLine($"{x} la so am!");
}
else
{
    Console.WriteLine($"{x} la so 0!");
}