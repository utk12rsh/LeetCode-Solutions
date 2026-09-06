public class Solution {
    public int[] Decrypt(int[] code, int k) {
        int n = code.Length;
        int[] decryptedCode = new int[n];
        int sum = 0;

        if(k > 0){
            for(int i = 1; i <= k; i++){
                sum += code[i];
            }

            decryptedCode[0] = sum;

            for(int j = 1; j < n; j++){
                sum -= code[j];
                sum += code[(j + k) % n];
                decryptedCode[j] = sum;
            }

            return decryptedCode;
        }
        else if(k == 0){
            for(int i = 0; i < n; i++){
                decryptedCode[i] = 0;
            }

            return decryptedCode;
        }
        else{
            for(int i = (n + k) % n; i < n; i++){
                sum += code[i];
            }

            decryptedCode[0] = sum;

            for(int i = 1; i < n; i++){
                sum -= code[((n + k) + (i - 1)) % n];
                sum += code[(i - 1) % n];

                decryptedCode[i] = sum;
            }

            return decryptedCode;
        }
    }
}