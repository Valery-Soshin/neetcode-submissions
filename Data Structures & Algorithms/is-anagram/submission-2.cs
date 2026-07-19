public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }

        var dictS = new Dictionary<char, int>();
        var dictT = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++){
            if (dictS.ContainsKey(s[i])){
                dictS[s[i]] = dictS[s[i]] + 1;
            }
            else{
                dictS[s[i]] = 1;
            }

            if (dictT.ContainsKey(t[i])){
                dictT[t[i]] = dictT[t[i]] + 1;
            }
            else{
                dictT[t[i]] = 1;
            }
        }

        foreach(var pair in dictS){
            if (dictT.TryGetValue(pair.Key, out var tCharCount)){
                if (pair.Value != tCharCount){
                    return false;
                }
            }
            else{
                return false;
            }
        }

        return true;
    }
}
