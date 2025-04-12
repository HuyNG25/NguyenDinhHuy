using System;

class Bai6
{
    // Ham sap xep mang so thuc theo chieu tang dan
    static void SapXepTangDan(ref double[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    // Hoan vi hai so
                    double tam = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tam;
                }
            }
        }
    }

    static void Main()
    {
        // Nhap vao so phan tu cua mang
        Console.Write("Nhap vao so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());

        // Khoi tao mang so thuc
        double[] arr = new double[n];

        // Nhap cac phan tu cua mang
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu {i + 1}: ");
            arr[i] = double.Parse(Console.ReadLine());
        }

        // In ra mang truoc khi sap xep
        Console.WriteLine("\nMang truoc khi sap xep:");
        foreach (double num in arr)
        {
            Console.Write(num + " ");
        }

        // Sap xep mang theo chieu tang dan
        SapXepTangDan(ref arr);

        // In ra mang sau khi sap xep
        Console.WriteLine("\nMang sau khi sap xep theo chieu tang dan:");
        foreach (double num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
