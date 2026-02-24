//In bảng nhân của một số bất kỳ
Console.Write("Nhap so bat ki: ");
int soN = int.Parse(Console.ReadLine());
for (int i=1; i<=9; i++)
{
    Console.WriteLine($"{soN} x {i} = {soN * i}");
}

//Hiển thị và tính tổng các số lẻ
Console.Write("Nhap so cac so: ");
int n = int.Parse(Console.ReadLine());
int tong = 0;
for (int i=0; i<=n; i++)
{
    if (i % 2 != 0)
    {
        Console.Write($"{i} ");
        tong = tong + i;
    }
}
Console.WriteLine($"Tong cac so le la {tong}");

//Vẽ tam giác sao. Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác rồi sau đó vẽ tam giác sao với độ rộng đó.
Console.Write("Nhap do rong: ");
int dodai = int.Parse(Console.ReadLine());

for (int i=0; i<dodai; i++)
{
    for (int j = 0; j<=i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
