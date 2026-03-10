//Trộn (ghép) hai mảng. Viết chương trình C# để trộn (ghép) hai mảng có cùng kích cỡ và sau đó sắp xếp các phần tử của mảng trộn này theo thứ tự tăng dần
Console.Write("Nhap so phan tu: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
Console.WriteLine("Nhap value");
for (int i=0; i<n; i++)
{
    Console.Write($"value {i}: ");
    int value = int.Parse(Console.ReadLine());
    arr[i] = value;
}

Console.WriteLine("Mang thu 2");
Console.Write("Nhap so phan tu mang 2 ");
int m = int.Parse(Console.ReadLine());
int[] arr2 = new int[m];
for (int i=0; i<m; i++)
{
    Console.Write($"value {i}: ");
    int value2= int.Parse(Console.ReadLine());
    arr2[i] = value2;
}

Console.WriteLine("Merge 2 mang");

int[] c = new int[n + m];
for (int i=0; i<n; i++)
{
    c[i] = arr[i];
}
for (int i=0; i<m; i++)
{
    c[n + i] = arr2[i];
}

for (int i=0; i< n+m; i++)
{
    for (int j = 0; j<n+m; j++)
    {
        if (c[i] < c[j])
        {
            int kq = c[i];
            c[i] = c[j];
            c[j] = kq;
        }
    }
}
Console.WriteLine("Mang da sap xep");

for (int i=0; i<n+m; i++)
{
    Console.Write($"{c[i]} ");
}
