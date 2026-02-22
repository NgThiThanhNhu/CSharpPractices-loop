//In bảng cửu chương. Viết chương trình C# để in bảng cửu chương.
Console.WriteLine("bang cuu chuong c#: ");
int num = 2;
do
{
    Console.WriteLine($"Bang cuu chuong {num}");
    for (int i=0; i<=10; i++)
    {
        Console.WriteLine($"{num} x {i} = {num * i}");
    }
    num++;
} while (num<=9);

//Kiểm tra số nguyên tố. Nhập một số và kiểm tra xem đó có phải là số nguyên tố không và hiển thị thông báo phù hợp.
Console.Write("Nhap so: ");
int soN = int.Parse(Console.ReadLine());
int biendem = 0;
for (int i=1; i<= soN; i++)
{
    if (soN % i == 0)
    {
        biendem++;
    }
}
if (biendem == 2)
{
    Console.WriteLine("So da cho la so nguyen to");
}
else
{
    Console.WriteLine("So da cho khong la so nguyen to");
}