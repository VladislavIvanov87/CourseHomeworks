﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for N:");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number which index we are going to looking for:");
            int S = int.Parse(Console.ReadLine());

            int[] nums = new int[N];
            Console.WriteLine("Enter {0} number(s) to array:", N);
            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int index = BinarySearch(nums, S, 0, nums.Length);

            if (index !=-1) Console.WriteLine("Number {0} found at index: {1}", S, index);
            else Console.WriteLine("Number {0} not found!", S);
        }

        private static int BinarySearch(int[] nums, int value, int start, int end)
        {
            if (end < start)
            {
                return -1;
            }
            else
            {
                int middleIndex = (start + end) / 2;
                if (nums[middleIndex] > value)
                {
                    return BinarySearch(nums, value, start, middleIndex - 1);
                }
                else if (nums[middleIndex] < value)
                {
                    return BinarySearch(nums, value, middleIndex + 1, end);
                }
                else
                {
                    return middleIndex;
                }
            }
        }
    }
}