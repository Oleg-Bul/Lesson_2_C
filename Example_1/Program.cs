﻿int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if(arg2>result) result = arg2;
  if(arg3>result) result = arg3;
  return result;
}

int a1 = 15;
int b1 = 27;
int c1 = 42;
int a2 = 22;
int b2 = 203;
int c2 = 88;
int a3 = 55;
int b3 = 424;
int c3 = 11;

//int max1 = Max(a1,b1,c1);
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
//int max = Max(max1,max2,max3);
int max = Max(
    Max(a1,b1,c1),
    Max(a2,b2,c2),
    Max(a3,b3,c3));
Console.WriteLine(max);