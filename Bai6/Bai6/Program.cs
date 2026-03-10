//Vẽ tam giác sao cân. Viết chương trình C# để nhập một số làm số hàng (hay độ rộng theo chiều ngang) của tam giác sao và sau đó vẽ tam giác sao cân có số hàng đó (mỗi hàng có số sao là số lẻ).
Console.Write("Nhap so hang: ");
int sh = int.Parse(Console.ReadLine());
for (int i = 0; i < sh; i++)
{
    for (int j = 1; j <= sh - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//Vẽ hình kim cương bằng dấu sao
Console.Write("nhap so hang mot nua cua hinh kim cuong: ");
int sohang = int.Parse(Console.ReadLine());
for (int i = 0; i < sohang; i++)
{
    for (int j = 1; j <= sohang - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for (int i = sohang; i > 0; i--)
{
    for (int j = sohang - i; j >= 1; j--)
    {
        Console.Write(" ");
    }
    for (int k = 2 * i - 1; k >= 1; k--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//In dãy Fibonacci. Viết chương trình C# để in n số đầu tiên trong dãy Fibonacci với n được nhập từ bàn phím. fibonaci là số sau bằng tổng 2 số đầu 
Console.Write("Nhap n: ");
int n = int.Parse(Console.ReadLine());
int a = 0, b = 1; 
for (int i=0; i<n; i++)
{
    Console.Write(a + " ");
    int next = a + b;
    a = b;
    b = next;
}