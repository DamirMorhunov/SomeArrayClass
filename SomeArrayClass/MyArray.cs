﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SomeArrayClass
{
    class MyArray
    {
        private int[] _array;
        private int _length;

        public MyArray()
        {
            _length = 0;
            _array = new int[_length];
        }
        public void Complete(int[] arr, int index)
        {
            int[] newArray = new int[array.Length + arr.Length];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index; i < arr.Length+index; i++)
            {
                int j = 0;
                newArray[i] = arr[j];
                j++;
            }
            //for (int i = arr.Length + index; i < ; i++)
            //{
            //    int j = newArray.Length - (arr.Length + array.Length);
            //    newArray[i] = array[i];

            //}
        }
        public void Info()
        {
            foreach (var item in array)
            {
                Console.Write(item +"\t");
            }
        }


    }
}
