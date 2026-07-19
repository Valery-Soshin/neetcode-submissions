public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }

        var orderedS = s.Order().ToArray();
        var orderedT = t.Order().ToArray();

        for(int i = 0; i < s.Length; i++){
            if (orderedS[i] != orderedT[i]){
                return false;
            }
        }

        return true;
    }
}
