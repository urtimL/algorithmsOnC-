int a1 = 15;
int b1 = 5;
int c1 = 3;
/////////////
int a2 = 20;
int b2 = 14;
int c2 = 56;
/////////////
int a3 = 8;
int b3 = 78;
int c3 = 7;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

Console.WriteLine($"max1 - {max1}, max2 - {max2}, max3 -{max3}");

int max = Max(max1, max2, max3);

Console.WriteLine($"max - {max}");