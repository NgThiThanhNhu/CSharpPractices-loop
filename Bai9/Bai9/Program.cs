//Vẽ chữ cái H bằng dấu sao.
for (int i=0; i<7; i++)
{
    Console.Write("*");
    if (i == 3)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write("*");
        }

    }
    else
    {
        Console.Write("    ");
    }
    Console.WriteLine("*");
    
}

//Vẽ chữ cái O bằng dấu sao
Console.WriteLine("Ve chu O");
for (int i=0; i<7; i++)
{
    if (i==0 || i== 6)
    {
        Console.WriteLine(" *** ");
    }
    else
    {
        Console.WriteLine("*   *");
    }
    
}

