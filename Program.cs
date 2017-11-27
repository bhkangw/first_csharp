using System;
using System.Collections.Generic;

namespace first_csharp
{
    class Program
    {
        // Print 1 - 255
        public static void Print1to255() {
            for(int i = 1; i < 256; i++){
                Console.WriteLine(i);
            }
        }

        // Print odd numbers between 1-255
        public static void PrintOdds() {
            for(int i = 1; i < 256; i+=2){
                Console.WriteLine(i);
            }
        }

        // Print Sum
        public static void PrintSum() {
            int sum = 0;
            for (int i = 1; i < 256; i++){
                sum = sum + i;
                Console.WriteLine("New number: " + i + " Sum: " + sum);
            }
        }

        // Iterating through an Array
        public static void ArrayIterate(int[] arr) {
            for(int i = 0; i < arr.Length; i++){
                Console.WriteLine(arr[i]);
            }
        }

        
        static void Main(string[] args)
        {
            Print1to255();
            PrintOdds();
            PrintSum();
            int[] myArr = new int[6] { 1, 3, 5, 7, 9, 13 };
            ArrayIterate(myArr);

            // Find Max
            int[] arr = { -1, 3, -5, 0, 19, 13 };
            int max = 0;
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] > max){
                    max = arr[i];
                }
            }
            Console.WriteLine(max);

            // Find Average
            int[] arr = { 1, 2, 3, 4, 5, 1, 1, 1 };
            int sum = 0;
            for(int i = 0; i < arr.Length; i++){
                sum += arr[i];
            }
            double avg = (double) sum / arr.Length;
            Console.WriteLine(avg);

            // Array with Odd Numbers
            int[] arr = new int[255/2 + 1];
            int c = 1;
            for(int i = 0; i < 255/2 + 1; i++){
                arr[i] = c;
                c+=2;
            }
            string toStringArr = String.Join(", ", arr);
            Console.WriteLine(toStringArr);

            // Greater than Y
            int[] arr = { 1, 2, 3, 4, 5, 8, 1, 1 };
            int Y = 3;
            int count = 0;
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] > Y){
                    count++;
                }
            }
            Console.WriteLine(count);

            // Square the Values
            int[] arr = { 1, -2, 3, 4, 5, 8, 1, 1 };
            for(int i = 0; i < arr.Length; i++){
                arr[i] = arr[i] * arr[i];
            }
            string toStringArr = String.Join(", ", arr);
            Console.WriteLine(toStringArr);

            // Eliminate Negative Numbers
            int[] arr = { 1, -2, 3, 4, -5, 8, 1, -1 };
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] < 0){
                    arr[i] = 0;
                }
            }
            string toStringArr = String.Join(", ", arr);
            Console.WriteLine(toStringArr);

            // Min, Max, and Average
            int[] arr = { 1, -2, 3, 4, -5, 8, 1, -5 };
            int min = 0;
            int max = 0;
            int sum = 0;
            for(int i = 0; i < arr.Length; i++){
                if(arr[i] < min){
                    min = arr[i];
                }
                if(arr[i] > max){
                    max = arr[i];
                }
                sum += arr[i];
            }
            float avg = (float) sum / arr.Length;
            Console.WriteLine(min + ", " + max + ", " + avg);

            // Shifting the values in an array
            int[] arr = { 1, 2, 3, 4 };
            for(int i = 0; i < arr.Length-1; i++){
                arr[i] = arr[i+1];
            }
            arr[arr.Length-1] = 0;
            string toStringArr = String.Join(", ", arr);
            Console.WriteLine(toStringArr);

            // Number to String
            object[] arr = new object[] { -1, 3, 2 - 16 };
            for(int i = 0; i < arr.Length; i++){
                if((int)arr[i] < 0){
                    arr[i] = "Dojo";
                }
            }
            return arr;
        }
    }
}