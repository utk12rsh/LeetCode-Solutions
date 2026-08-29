public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] answer = new int[temperatures.Length];
        Stack<int> s = new Stack<int>();

        answer[temperatures.Length - 1] = 0;
        s.Push(temperatures.Length - 1);

        for(int i = temperatures.Length - 2; i >= 0; i--){
            if(temperatures[i] < temperatures[s.Peek()]){
                int days = s.Peek() - i;
                answer[i] = days;
                s.Push(i);
            }
            else{
                s.Pop();
                while(s.Count > 0){
                    int prev = s.Peek();
                    if(temperatures[i] < temperatures[prev]){
                        int days = prev - i;
                        answer[i] = days;
                        s.Push(i);
                        break;
                    }
                    else{
                        s.Pop();
                    }
                }

                 if(s.Count == 0)
                    s.Push(i);
            }
        }
        return answer;
    }
}