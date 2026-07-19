public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }

        var dict = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++){
            if (dict.ContainsKey(s[i])){
                dict[s[i]] = dict[s[i]] + 1;
            }
            else{
                dict[s[i]] = 1;
            }
            
            if (dict.ContainsKey(t[i])){
                dict[t[i]] = dict[t[i]] - 1;
            }
            else{
                dict[t[i]] = -1;
            }
        }

        foreach(var pair in dict){
            if (pair.Value > 0){
                return false;
            }
        }

        return true;
    }
}
