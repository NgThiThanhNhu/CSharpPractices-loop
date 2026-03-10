// In số theo chiều đảo ngược
Console.Write("Nhap so: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.Write(i);
}
Console.WriteLine();
for (int i = n; i > 0; i--)
{
    Console.Write(i);
}

//Chuyển đổi nhị phân thành thập phân. Viết chương trình C# để chuyển đổi một số trong hệ nhị phân thành một số trong hệ thập phân. Ví dụ: số trong hệ thập phân tương đương với số trong hệ nhị phân 11001 là số 25.
Console.Write("Nhap so nhi phan: ");
string soN = Console.ReadLine();
int kq = 0;
foreach (var bit in soN)
{
    kq = kq * 2 + (bit - '0');
}
Console.WriteLine("So thap phan: " + kq);

//Đọc và in các phần tử mảng
Console.Write("Nhap so n: ");
int so = int.Parse(Console.ReadLine());
int[] arr = new int[so];
for (int i = 0; i < so; i++)
{
    Console.Write($"Nhap value {i} ");
    int value = int.Parse(Console.ReadLine());
    arr[i] = value;
}
for (int i = 0; i < so; i++)
{
    Console.WriteLine($"Phan tu thu {i} la " + arr[i]);
}

//In mảng theo chiều đảo ngược
Console.Write("Nhap so phan tu: ");
int pt = int.Parse(Console.ReadLine());
int[] ar = new int[pt];
for (int i=0; i<pt; i++)
{
    Console.Write($"Nhap phan tu thu {i}: ");
    int val = int.Parse(Console.ReadLine());
    ar[i] = val;
}
Console.WriteLine("In mang nguoc");
for (int i=pt-1; i>=0; i--)
{
    Console.WriteLine(ar[i]);
}