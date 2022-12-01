//Valid Anagram
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> s1 = new Dictionary<char, int>();
        if (s.Length != t.Length)
        {
            return false;
        }
        else
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!s1.ContainsKey(s[i]))
                {
                    s1[s[i]] = 1;
                }
                else
                {
                    s1[s[i]] += 1;
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (!s1.ContainsKey(t[i]))
                {
                    s1[t[i]] = -1;
                }
                else
                {
                    s1[t[i]] -= 1;
                    if (s1[t[i]] == 0)
                    {
                        s1.Remove(t[i]);
                    }
                }

            }
            return s1.Count == 0;

        }


    }
}