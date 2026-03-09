//Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác và sau đó vẽ tam giác số cân có số hàng đó và các số trong tam giác được hiển thị theo thứ tự tăng dần
Console.Write("Nhap so hang: ");
int sohang = int.Parse(Console.ReadLine());
int count = 1;
int bien_dem = sohang;
for (int i = 0; i < sohang; i++)
{
    for (int k = bien_dem; k >= 1; k--)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write($" {count++}");
    }
    Console.WriteLine();
    bien_dem--;
}

//Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác và sau đó vẽ tam giác số cân có số hàng đó và các số được lặp lại trong mỗi hàng
Console.Write("Nhap so hang: ");
int sh = int.Parse(Console.ReadLine());
int biendem = 1;
int khoangtrong = sh;
for (int i = 0; i < sh; i++)
{
    for (int k = khoangtrong; k >= 1; k--)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write($"{biendem} ");
    }
    biendem++;
    Console.WriteLine();
    khoangtrong--;
}

//Vẽ tam giác sao đều. Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác sao và sau đó vẽ tam giác sao đều có số hàng đó
Console.Write("Nhap so hang: ");
int sohang = int.Parse(Console.ReadLine());
int kt = sohang;
for (int i = 0; i < sohang; i++)
{
    for (int k = kt; k >= 1; k--)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
    kt--;
}

