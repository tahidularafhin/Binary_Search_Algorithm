using System;

namespace Binary_Search_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide input search iteam: ");
            int searchItem = int.Parse(Console.ReadLine());
            int[] arr = { 5, 11, 13, 25, 40, 33, 49, 50, 62, 67, 73 };
            int result = BinarySearch(arr, searchItem);
            if (result < 0)
            {
                Console.WriteLine($"{searchItem} is not found");
            }
            else
            {
                Console.WriteLine($"{searchItem} is found at index: {result}");
            }
            Console.ReadLine();
        }
       public  static int BinarySearch(int[] arr, int searchItem)
        {
            
            int start = 0;
            int end = arr.Length-1;
            while(start<= end)
            {
                int mid = (start + end) / 2;
                if (searchItem == arr[mid])
                {
                    return mid;
                }
                else if (searchItem < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;

        }
    }
}
