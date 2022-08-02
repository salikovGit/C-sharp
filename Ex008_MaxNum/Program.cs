int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 12, 23, 42, 134, 234, 12, 43, 23, 12 };

int max1 = Max(1, 2, 3);
int max2 = Max(2, 324, 1);
int max3 = Max(3, 212, 43);
int max = Max(max1, max2, max3);
Console.WriteLine(max);