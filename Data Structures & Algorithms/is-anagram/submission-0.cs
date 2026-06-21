public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] charS = s.ToCharArray(); 
        char[] charT = t.ToCharArray();
        Array.Sort(charS);
        Array.Sort(charT);
        if (charS.Length != charT.Length) return false; 
        for (int i = 0; i < charS.Length; i++){
            if (charS[i] != charT[i]) return false;
        }
        return true;
    }
}
// Any order characters in the string, just have to be the same ones 
// So the length does matter, but more over the content of the strings. 
// again you could brute force with for loop. Check each letter in the
// first word, to the second word.

// can have duplicate letters
// So I see the path -->
// Sort both words, string compare, return true if same string, false if not.