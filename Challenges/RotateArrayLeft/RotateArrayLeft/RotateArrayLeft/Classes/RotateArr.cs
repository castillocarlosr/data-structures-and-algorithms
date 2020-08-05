using System;
using System.Collections.Generic;
using System.Text;

namespace RotateArrayLeft.Classes
{
    public class RotateArr
    {
        public int[] LeftRotate(int[] arr, int d)
        {
            /*
            int[] result = new int[arr.Length];
            for (int i = d, j=0; i < arr.Length; i++, j++)
            {  
            result[j] = arr[i];
            }
            for (int k = 0, l=d-1; k < d; k++, l++)
            {
            result[l] = arr[k];
            }
            return result;
            */
            d = d % arr.Length;
            int[] buffer = new int[d];
            Array.Copy(arr, buffer, d);
            Array.Copy(arr, d, arr, 0, arr.Length - d);
            Array.Copy(buffer, 0, arr, arr.Length - d, d);
            return arr;
        }

        /****  Right Rotate Array coming sooon  ****/
    }
}
