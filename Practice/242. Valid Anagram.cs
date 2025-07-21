/*
O(n)
bruteforce
*/
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(t.Length > s.Length){
            return false;
        }
        var map = new Dictionary<char, int>();
        for(int i=0; i<s.Length; i++){
            char c=s[i];
            if(map.ContainsKey(c)){
                map[c] += 1;
                continue;
            }
            map[c] = 1;
        }

        for(int i=0; i<t.Length; i++){
            char d = t[i];
            if(map.ContainsKey(d)){
                map[d] -= 1;
            }
            else{
                return false;
            }
        }

        foreach(var m in map){
            if(m.Value >= 1){
                return false;
            }
        }
        return true;
    }
}