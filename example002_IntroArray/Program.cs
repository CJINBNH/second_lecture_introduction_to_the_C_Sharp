Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 11;
// int b2 = 23;
// int c2 = 353;
// int a3 = 13;
// int b3 = 1223;
// int c3 = 33;
int[] array = { 111, 22, 33, 44, 55, 66, 77, 88, 99 };

// int max1 = Max (a1, b1, c1);
// int max2 = Max (a2, b2, c2);
// int max3 = Max (a3, b3, c3);
// int max = Max (max1, max2, max3);

int max = Max (Max (array[0], array[1], array[2]), Max (array[3], array[4], array[5]), Max (array[6], array[7], array[8]));

Console.WriteLine(max);
