int Nam;
Console.WriteLine("Nhap vao so nam: ");
Nam = int.Parse(Console.ReadLine() ?? "0");
if (Nam % 4 == 0 && Nam % 100 != 0 || Nam % 400 == 0)
{
    Console.WriteLine($"{Nam} la nam nhuan!");
}
else
{
    Console.WriteLine($"{Nam} khong phai nam nhuan!");
}