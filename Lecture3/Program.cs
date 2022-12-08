/*
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
*/
//______________________________array_______________________________
/*
int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);
*/
//_____________________cycle while____________________________
/*
int[] array = { 1, 2, 3, 4, 5, 6, 4, 8, 9 };
int n = array.Length;
int index = 0;
int find = 4;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
*/
//______________________________void_____________________________
/*
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
*/
//_____________________four types of methods________________________

//_____________________________first________________________________
/*void Method1()
{
    System.Console.WriteLine("Autor ...");
}
//Method1(); //-вызов метода 
*/
//______________________________second______________________________ 
/*
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
//Method2("Hello");

void Method21(string msg, int count)
{
    int i = 0;

    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method21("test", 4);
//Method21(count: 4, msg: "test");

//______________________Ctrl+C - прерывание цикла
*/
//_______________________________third______________________________
/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/

//_______________________________fourth_____________________________
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
}

string res = Method4(4, "asdF");
Console.WriteLine(res);
*/

//______________________cycle for_____________________________
/*
string Method4(int count, string text)
{
    string result = string.Empty;

    for (int i = 0; i < count; i++)
    {
        result += text;
    }

    return result;
}

string res = Method4(4, "asdF");
Console.WriteLine(res);
*/

//_____________________cycle in cycle___________________________
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

//_________________replacing characters in text____________________

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками
/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
*/

//______________________selection sort algorithm_________________________

int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);