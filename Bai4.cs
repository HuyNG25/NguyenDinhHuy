using System;

class Bai4
{
    // Ham tim so lon thu hai trong mang
    static int TimSoLonThuHai(int[] arr)
    {
        if (arr.Length < 2)
        {
            throw new InvalidOperationException("Mang phai co it nhat hai phan tu.");
        }

        int soLonNhat = int.MinValue;  // So lon nhat
        int soLonThuHai = int.MinValue; // So lon thu hai

        foreach (int num in arr)
        {
            if (num > soLonNhat)
            {
                soLonThuHai = soLonNhat;
                soLonNhat = num;
            }
            else if (num > soLonThuHai && num != soLonNhat)
            {
                soLonThuHai = num;
            }
        }

        return soLonThuHai;
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

        try
        {
            // Tim so lon thu hai va in ket qua
            int soLonThuHai = TimSoLonThuHai(arr);
            Console.WriteLine($"\nSo lon thu hai trong mang la: {soLonThuHai}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
