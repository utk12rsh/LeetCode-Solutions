public class Solution
{
    public string ReverseStr(string s, int k)
    {
        char[] chars = s.ToCharArray();

        for (int x = 0; x < chars.Length; x += 2 * k)
        {
            int n = Math.Min(k, chars.Length - x);
            int mid = n / 2;

            for (int i = 0; i < mid; i++)
            {
                char temp = chars[x + i];
                chars[x + i] = chars[x + n - 1 - i];
                chars[x + n - 1 - i] = temp;
            }
        }

        return new string(chars);
    }
}