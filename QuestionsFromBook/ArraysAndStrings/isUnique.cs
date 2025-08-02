/*
Implement an algorithm to determine if a string has all unique characters. What if you cannot use
additional data structures?
*/

//Using Dictionary
bool isUniqueChars(string str){
  var map = new Dictionary<char, bool>();
  for(int i=0; i<str.Length; i++){
    var ch = str[i];
    if(map.ContainsKey(ch)){
      return false;
    }
    map[ch] = true;
  }
  return true;
}

var result = isUniqueChars("string");
Console.WriteLine(result);

//Using Array
bool isUniqueCharsByArray(string str){
  if(str.Length > 128){
    return false;
  }
  var charSet = new bool[128];
  for(int i=0; i<str.Length; i++){
    var val = (int)str[i];
    if(charSet[val]){
      return false;
    }
    charSet[val] = true;
  }
  return true;
}

var resultByArray = isUniqueCharsByArray("string");
Console.WriteLine(resultByArray);