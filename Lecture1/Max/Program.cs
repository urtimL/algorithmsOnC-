int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;

    return result;
}

int a1 = 15, b1 = 8, c1 = 5;
int a2 = 1, b2 = 18, c2 = 25;
int a3 = 11, b3 = 81, c3 = 51;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max(max1, max2, max3);

System.Console.WriteLine(max);