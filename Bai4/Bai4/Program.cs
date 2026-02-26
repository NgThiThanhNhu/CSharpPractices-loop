//Vẽ tam giác số. Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác và sau đó vẽ tam giác số có số hàng đó.
Console.Write("Nhap so ma ban muon ve tam giac so: ");
int soN = int.Parse(Console.ReadLine());
for (int i=1; i<=soN; i++)
{
    for (int j=1; j<=i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}

//Vẽ tam giác số. Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác và sau đó vẽ tam giác số có số hàng đó và các số được lặp lại trong mỗi hàng.
Console.Write("Nhap so n: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int count = i;
    for (int j = 1; j <= i; j++)
    {
        Console.Write(count);
    }
    Console.WriteLine();
}

//Vẽ tam giác số. Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác và sau đó vẽ tam giác số có số hàng đó và các số trong tam giác được hiển thị theo thứ tự tăng dần.
Console.Write("Nhap so n: ");
int a = int.Parse(Console.ReadLine());
int add = 1;
for (int i=1; i<=a; i++)
{
    for (int j=1; j<=i; j++)
    {
        Console.Write($"{add++} ");
    }
    Console.WriteLine();
}

