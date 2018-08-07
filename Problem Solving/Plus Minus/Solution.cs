using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

class Solution {

    /*
     * Complete the plusMinus function below.
     */
    static void plusMinus(int[] arr) {
        /*
         * Write your code here.
         */
        float positives = 0;
        float negatives = 0;
        float zeros = 0;
        int arrSize = arr.Length;
        for(int i = 0; i<arrSize ;i++){
            if(arr[i] > 0){
                positives++;
            }
            else if(arr[i] < 0){
                negatives++;
            }
            else{
                zeros++;
            }
        }
        
            
//         Console.WriteLine(positives);
//         Console.WriteLine(negatives);
//         Console.WriteLine(zeros);
        
        positives /= arrSize;
        negatives /= arrSize;
        zeros /= arrSize;
        

        
       Console.WriteLine(String.Format("{0:0.000000}",positives));
        Console.WriteLine(String.Format("{0:0.000000}",negatives));
        Console.WriteLine(String.Format("{0:0.000000}",zeros));
        
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
