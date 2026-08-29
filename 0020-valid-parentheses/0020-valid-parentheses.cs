public class Solution {
    public bool IsValid(string s) {
        var map = new Dictionary<char, char>{
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };

        var stack = new Stack<char>();

        foreach(char c in s){
            if(map.ContainsKey(c)){
                stack.Push(c);
            }
            else{
                if(stack.Count == 0)
                    return false;

                char top = stack.Pop();

                if(map[top] != c)
                    return false;
            }
        }

        return stack.Count == 0;
    }
}