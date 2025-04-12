Console.Write("Nhap vao mot so nguyen duong: ");
int n = int.Parse(Console.ReadLine());

// Kiểm tra số nguyên tố
if (n <= 1)
{
    Console.WriteLine($"{n} khong phai la so nguyen to.");
}
else
{
    bool isPrime = true;
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0) // Nếu n chia hết cho i, không phải số nguyên tố
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine($"{n} la so nguyen to.");
    }
    else
    {
        Console.WriteLine($"{n} khong phai la so nguyen to.");
    }
}