using System;
class Bai2
{
    static bool IsPrime(int n)
    {
        if (n <= 1) return false; 
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false; 
        }
        return true;
    }
    static void Main()
    {
        Console.Write("Nhap vao so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nCac so nguyen to trong mang la:");
        for (int i = 0; i < n; i++)
        {
            if (IsPrime(arr[i]))
            {
                Console.WriteLine($"Chi so {i}: Gia tri {arr[i]}");
            }
        }
    }
}
