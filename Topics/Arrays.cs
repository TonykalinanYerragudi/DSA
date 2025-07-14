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

List<object> objects = new List<object>(){"string", 1, true};
foreach(var obj in objects){
  Console.WriteLine(obj);
}

public class MyArray{
  public int Length{get; set;}
  private Dictionary<int, object> data;
  
  public MyArray(){
    this.Length = 0;
    this.data = new Dictionary<int, object>();
  }

  public object Get(int index){
    return this.data[index];
  }

  public void Push(object obj){
    this.data[this.Length] = obj;
    this.Length++;
  }

  public object Pop(){
    var obj = this.data[this.Length-1];
    this.data.Remove(this.Length-1);
    this.Length--;
    return obj;
  }

  public void Delete(int index){
    var item = this.data[index];
    Shiftitems(index);
  }

 // delete index 1
 // hi hello you now
 // hi you now 
  public void Shiftitems(int index){
    for(int i=index; i<this.Length - 1; i++){
      this.data[i] = this.data[i+1];
    }
    this.data.Remove(this.Length-1);
    this.Length--;
  }

  public override string ToString()
    {
        if (this.Length == 0)
            return "MyArray is empty.";

        string result = "MyArray: ";
        for (int i = 0; i < this.Length; i++)
        {
            result += this.data[i] + " ";
        }
        return result.Trim();
    }
}

class Program
{
    static void Main()
    {
        var myarr = new MyArray();
        Console.WriteLine(myarr.ToString()); 
    }
}


var str = "Think";
var arr5 = str.ToArray();
for(int i=0; i<arr5.Length/2; i++){
  var temp = arr5[i];
  arr5[i] = arr5[(arr5.Length-1) - i];
  arr5[(arr5.Length-1) - i] = temp;
}
str = "";
foreach(var c in arr5){
  str += c;
}
Console.WriteLine(str);

int[] arrn1 = new int[] {10, 3, 40, 31};
int[] arrn2 = new int[] {1, 60, 30};
var nn = mergeSortedArrays(arrn1, arrn2);
foreach(var i in nn){
  Console.WriteLine(i);
}
List<int> mergeSortedArrays(int[] n1, int[] n2){
  var n3 = new List<int>();

  foreach(var a in n1){
    n3.Add(a);
  }
  foreach(var b in n2){
    n3.Add(b);
  }

  for(int i=0; i<n3.Count-1; i++){
    int count = i;
    for(int j=i+1; j<n3.Count; j++){
      if(n3[i] > n3[j]){
        var temp = n3[i];
        n3[i] = n3[j];
        n3[j] = temp;
        count++;
      }
    }
  }
  return n3;
}