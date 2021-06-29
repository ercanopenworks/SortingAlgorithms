using System;

namespace sortingAlgorithms
{
    class Program
    {
        public static void SelectionSort(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minInd = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minInd])
                    {
                        minInd = j;
                    }

                }
                temp = arr[minInd];
                arr[minInd] = arr[i];

                arr[i] = temp;
            }
            Console.WriteLine($"Selection sort form :  {string.Join(",", arr)}");

        }
        public static void BubleSort(int[] arr)
        {
            
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }


                }

            }
            Console.WriteLine($"Buble sort form :  {string.Join(",", arr)}");

        }
        public static void insertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int val = arr[i];
                int j = i - 1;
                while(j>=0 && val < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j -= 1;

                }
                arr[j + 1] = val;
            }

            Console.WriteLine($"Insertion sort form :  {string.Join(",", arr)}");
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3,5,1, 4,19,50,48,36,26,27,15,38,2};

            //insertionSort(arr);
            //BubleSort(arr);
            SelectionSort(arr);

            Console.ReadKey();
        }
    }
}
