using System;

namespace Minimum_Swaps_2
{
    class Program
    {
    static int minimumSwaps(int[] arr) {
        int swapCount = 0;
        for(int i = 0; i < arr.Length; i++){
        // Console.WriteLine(i);
            swap(ref arr,ref swapCount,i,arr[i]-1);

            if(arr[i] != i+1){
                swap(ref arr,ref swapCount,i,arr[i]-1);
            }

            for (int j = 2; j <= 15; j++)
            {
                if((i+j < arr.Length-j) && (arr[i+j] != i+j+1)){
                    swap(ref arr,ref swapCount,i+j,arr[i+j]-1);
                }
            }
         
        }
                // for(int j = 0; j < arr.Length; j++){
                //     Console.Write(arr[j] + " ");
                // }
                // Console.Write("\n");
        return swapCount;
    }
    
    static void swap(ref int[] arr, ref int swapCount, int x, int y){
        if(y > arr.Length -1){
            y = arr.Length - 1;
        }
        if( x == y ){
            return;
        }

        int temp = arr[x];
        arr[x] = arr[y];
        arr[y] = temp;
        swapCount++;
        
        // Console.Write("Swap("+x+","+y+")"+" count:"+ swapCount+"\n");
    }

        static void Main(string[] args)
        {
            int[] arr = new int[]{3,7,6,9,1,8,10,4,2,5};
            int[] arr2 = new int[]{2, 31, 1, 38, 29, 5, 44, 6, 12, 18, 39, 9, 48, 49, 13, 11, 7, 27, 14, 33, 50, 21, 46, 23, 15, 26, 8, 47, 40, 3, 32, 22, 34, 42, 16, 41, 24, 10, 4, 28, 36, 30, 37, 35, 20, 17, 45, 43, 25, 19};
            // source: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file
            string[] text = System.IO.File.ReadAllLines("input/input10.txt");
            string[] str = text[1].Split(' ');
            int[] arr3 = new int[str.Length];
            for (int i = 0; i<str.Length; i++)
            {
                arr3[i] = int.Parse(str[i]);
            }

            int[] arr4 = new int[]{8, 45, 35, 84, 79, 12, 74, 92, 81, 82, 61, 32, 36, 1, 65, 44, 89, 40, 28, 20, 97, 90, 22, 87, 48, 26, 56, 18, 49, 71, 23, 34, 59, 54, 14, 16, 19, 76, 83, 95, 31, 30, 69, 7, 9, 60, 66, 25, 52, 5, 37, 27, 63, 80, 24, 42, 3, 50, 6, 11, 64, 10, 96, 47, 38, 57, 2, 88, 100, 4, 78, 85, 21, 29, 75, 94, 43, 77, 33, 86, 98, 68, 73, 72, 13, 91, 70, 41, 17, 15, 67, 93, 62, 39, 53, 51, 55, 58, 99, 46};
            int[] arr5 = new int[]{1, 3, 5, 2, 4, 6, 8};
            text = System.IO.File.ReadAllLines("input/input08.txt");
            str = text[1].Split(' ');
            int[] arr6 = new int[str.Length];
            for (int i = 0; i<str.Length; i++)
            {
                arr6[i] = int.Parse(str[i]);
            }

            text = System.IO.File.ReadAllLines("input/input06.txt");
            str = text[1].Split(' ');
            int[] arr7 = new int[str.Length];
            for (int i = 0; i<str.Length; i++)
            {
                arr7[i] = int.Parse(str[i]);
            }

            Console.WriteLine(minimumSwaps(arr3));
            Console.WriteLine(minimumSwaps(arr6));
            Console.WriteLine(minimumSwaps(arr7));
        }
    }
}
