int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;

    return result;
}

int[] array = { 15, 2, 5, 18, 81, 56, 78, 100, 57 };


int max1 = Max(array[0], array[1], array[2]);
int max2 = Max(array[3], array[4], array[5]);
int max3 = Max(array[6], array[7], array[8]);

int max = Max(max1, max2, max3);

System.Console.WriteLine(max);
