using System;

class Bai3
{
    // Ham dem so luong so duong va so am trong mang
    static void DemSoLuongSoDuongVaSoAm(int[] arr, out int soDuong, out int soAm)
    {
        soDuong = 0;
        soAm = 0;

        foreach (int num in arr)
        {
            if (num > 0)
            {
                soDuong++;
            }
            else if (num < 0)
            {
                soAm++;
            }
        }
    }

    static void Main()
    {
        // Nhap vao so phan tu cua mang
        Console.Write("Nhap vao so phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());

        // Khoi tao mang
        int[] arr = new int[n];

        // Nhap cac phan tu vao mang
        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Dem so luong so duong va so am
        int soDuong, soAm;
        DemSoLuongSoDuongVaSoAm(arr, out soDuong, out soAm);

        // In ket qua
        Console.WriteLine($"\nSo luong so duong trong mang la: {soDuong}");
        Console.WriteLine($"So luong so am trong mang la: {soAm}");
    }
}
