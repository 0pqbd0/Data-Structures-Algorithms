// public class Solution {
//     public bool IsAnagram(string s, string t) {
//         var sA = s.ToArray();
//         Array.Sort(sA);
//         var sN = new string(sA);
//         var sA1 = t.ToArray();
//         Array.Sort(sA1);
//         var sN1 = new string(sA1);

//         return sN == sN1;
//     }
// }

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false ;
        int[] store = new int [26];
        foreach(char c in s){
            store[c-'a']++;
        }
        foreach(char c in t){
            if(store[c -'a']> 0){
                store[c - 'a']--;
            }else{
                return false ;
            }
        }
        return true;
    }
}