/*
"When a function calls itself" until a specific condition is met

f(){
print()
f()    -- calling a function itself 
}

main(){
f()
}

Now in above example there is no specific condition, so it will leads to stackOverFlow.
        .....
|   ....|   .  
| f()   |   .
| f()   |
 _______

with base condition:
*/
using System;

int count = 0;

int fun()
{
  if (count == 5)
  {
    return count;
  }
  Console.WriteLine(count);
  count++;
  return fun();
}

fun();

/*
output:

0
1
2
3
4

*/


/*
Recursion Tree

  f()  ->
    <- f()
       ->
    <- f()

*/