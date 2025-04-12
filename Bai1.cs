using System;

class Bai1
{
    // Hàm tính tổng các số chẵn trong mảng
    static int SumEvenNumbers(int[] arr)
    {
        int sum = 0;

        // Lặp qua tất cả các phần tử trong mảng
        foreach (int num in arr)
        {
            // Nếu số chẵn, cộng vào tổng
            if (num % 2 == 0)
            {
                sum += num;
            }
        }

        return sum;
    }

    static void Main()
    {
        // Khởi tạo mảng ví dụ
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Gọi hàm và in kết quả
        int result = SumEvenNumbers(numbers);
        Console.WriteLine($"Tong cua cac so chan trong mang la: {result}");
    }
}
