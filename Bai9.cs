int n;
Console.WriteLine("Nhap vao mot so nguyen duong: ");
n = int.Parse(Console.ReadLine());

// Kiểm tra nếu n là số nguyên dương (n > 0)
if (n > 0)
{
    long result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    Console.WriteLine($"Ket qua giai thua cua so {n} la: " + result);
}
// Nếu n là 0 hoặc số âm
else if (n == 0)
{
    Console.WriteLine("Giai thua cua 0 la 1.");
}
else
{
    Console.WriteLine($"{n} khong phai la 1 so nguyen duong!");
}
