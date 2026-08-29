public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        for(int i = 0; i < tokens.Length; i++){
            int op1 = 0, op2 = 0, result = 0;
            switch(tokens[i]){
                case "+":
                    op1 = stack.Pop();
                    op2 = stack.Pop();
                    result = op2 + op1;
                    stack.Push(result);
                    break;
                case "-":
                    op1 = stack.Pop();
                    op2 = stack.Pop();
                    result = op2 - op1;
                    stack.Push(result);
                    break;
                case "*":
                    op1 = stack.Pop();
                    op2 = stack.Pop();
                    result = op2 * op1;
                    stack.Push(result);
                    break;
                case "/":
                    op1 = stack.Pop();
                    op2 = stack.Pop();
                    result = op2 / op1;
                    stack.Push(result);
                    break;
                default:
                    stack.Push(int.Parse(tokens[i]));
                    break;
            }
        }
        return stack.Pop();
    }
}