using System;

class Bai5
{
    // Ham hoan vi hai so a va b
    static void HoanVi(ref int a, ref int b)
    {
        int tam = a;
        a = b;
        b = tam;
    }

    static void Main()
    {
        // Nhap vao hai so nguyen a va b
        Console.Write("Nhap vao so a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap vao so b: ");
        int b = int.Parse(Console.ReadLine());

        // In ra gia tri truoc khi hoan vi
        Console.WriteLine($"\nTruoc khi hoan vi: a = {a}, b = {b}");

        // Hoan vi hai so a va b
        HoanVi(ref a, ref b);

        // In ra gia tri sau khi hoan vi
        Console.WriteLine($"\nSau khi hoan vi: a = {a}, b = {b}");
    }
}
