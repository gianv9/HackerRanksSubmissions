using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the diagonalDifference function below.
     */
    static int diagonalDifference(int[][] a) {
        /*
         * Write your code here.
         */
        int order = a.Length;
        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;
        for(int i = 0; i < order; i++){
            // primary diagonal sum
            primaryDiagonalSum += a[i][i];
            
            // secondary diagonal sum
            secondaryDiagonalSum += a[(order-1)-i][i];
        }
        return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] a = new int[n][];

        for (int aRowItr = 0; aRowItr < n; aRowItr++) {
            a[aRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        }

        int result = diagonalDifference(a);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
