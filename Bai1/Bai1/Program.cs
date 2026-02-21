//Bai1: Tính tổng dãy số. Viết chương trình C# để tính tổng 10 số đầu tiên được nhập từ bàn phím.
Console.WriteLine("Tong 10 so dau tien");
int sum = 0;
for (int i=0; i<10; i++)
{
    sum = sum + i;
    Console.WriteLine(i);
}
Console.WriteLine("Tong 10 so tren la {0}", sum);


//Bai2: Hiển thị các số Hex từ 0-255. Viết chương trình C# để hiển thị các số trong hệ thập lục phân có giá trị 0-255 (hệ thập phân) trong 16 hàng, trong đó: hàng đầu sẽ gồm các số từ 0-15, hàng thứ hai sẽ gồm các số từ 16-31, ...
Console.WriteLine("Hien thi so hex");
int socuoi = 0;
for (int i=0; i<16; i++)
{
    for (int j= 0; j<=15; j++)
    {
        Console.Write("{0} ", socuoi);
        socuoi = socuoi + 1;
    }
    Console.WriteLine();
}

