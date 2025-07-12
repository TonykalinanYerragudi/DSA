/*
Arrays Notes

Array is a collection of items.
insert at end. O(1)
insert in a postion. O(n)
delete. O(n)
search with index. O(1)

static
int[] arr = new int[5];
int[] arr = {1, 2, 3, 4};

dynamic array
List<int> list = new List<int>();
*/
using System;
//static array
int[] arr = new int[5];

//dynamic arrar
List<int> list = new List<int>();
for(int i = 0; i < arr.Length; i++)
{
  arr[i] = i + 1;
  list.Add(i+1);
}

for (int i = 0; i < arr.Length; i++)
{
  Console.WriteLine("array: "+ arr[i]);
  Console.WriteLine("list: "+ list[i]);
}
