using System;
using System.Collections.Generic;
using System.Text;

namespace Класи1
{
    class Class
    {
        public int[] s;

        public Class(int[] s)
        {
            this.s = s;
        }

        public int[] Array
        {
            get
            {
                return s;
            }
        }
        public int[] printArray(int[] arr)
        {
           
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,8:f}  ", arr[i]);
            }
            return arr;
        }
        public int[] Add( ref int[] arr, int value, int index )
        {
            int[] newArr = new int[arr.Length + 1];
            newArr[index] = value;
            for (int i = 0; i < index; i++)
                newArr[i] = arr[i];
            for (int i = index; i < arr.Length; i++)
                newArr[i + 1] = arr[i];
            for (int i = 0; i < newArr.Length; i++)
                Console.Write("{0,8:f}  ", newArr[i]);
            return newArr;
        }
     
        public int Max(int[] arr)
        {
            int maxValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > maxValue)
                    maxValue = arr[i];
            return maxValue;
        }
        public int GetSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    sum += arr[i];
            }
            return sum;
        }
    }
}

