int chieuDai, chieuRong, dienTich;
Console.Write("Nhap vao chieu dai: ");
chieuDai = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Nhap vao chieu rong: ");
chieuRong = int.Parse(Console.ReadLine() ?? "0");
dienTich = chieuDai * chieuRong;
Console.WriteLine("Dien tich hinh chu nhat la: " + dienTich);