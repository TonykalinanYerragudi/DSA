/*
Arrays Notes

Array is a collection of items.
insert at end. O(1)
insert in a postion. O(n)
delete. O(n)
search with index. O(1)

int[] arr = new int[5];
int[] arr = {1, 2, 3, 4};

*/
using System;
int[] arr = new int[5];

for(int i = 0; i < arr.Length; i++)
{
  arr[i] = i + 1;
}

for (int i = 0; i < arr.Length; i++)
{
  Console.WriteLine(arr[i]);
}
