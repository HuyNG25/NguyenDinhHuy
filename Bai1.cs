//Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào  [tên], bạn[tuổi] tuổi!". 
String ten;
int tuoi;
Console.Write("Nhap ten: ");
ten = Console.ReadLine();
Console.Write("Nhap tuoi: ");
tuoi = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Xin chao " + ten + ", ban " + tuoi + " tuoi ");
