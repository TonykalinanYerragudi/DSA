/*Dictionaries

For eg:
Key -> blackbox -> Memory address
"apple" -> blackbox -> 843
 --------------
| Key  | Value |
| 843  | 900   |
 --------------

A Hash function is a function that generates a value of fixed
length for each input that it gets.

insert O(1)
lookup O(1)
delete O(1)
search O(1)

Hash Collisions

1. Hashtable
2. Dictionary<TKey, TValue>
3. SortedDictionary<TKey, TValue>
4. ConcurrentDictionary<TKey, TValue>
5. ImmutableDictionary<TKey, TValue>
*/

List<int> list = new List<int>()
{
  //2, 5, 1, 2, 3, 4, 6, 3, 2
  //2, 1, 1, 3, 343, 2, 43
  2, 3, 4, 6
};
var map = new Dictionary<int, int>();
int map_map()
{
  for (int i = 0; i < list.Count; i++)
  {
    int n = list[i];
    if (!map.ContainsKey(n))
    {
      map[n] = 1;
      continue;
    }
    return n;
  }
  return 0;
}
Console.WriteLine(map_map());
