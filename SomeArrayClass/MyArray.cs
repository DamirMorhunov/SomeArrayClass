using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SomeArrayClass
{
    class MyArray
    {
        int[]? array;
        public MyArray() => array = new int[0];

        public void Add(int x) => array[array.Count() - 1] = x;
        public void Remove() => array[array.Count() - 1] = 0;// i don't have another idea...
        public void Clear() => array =new int[array.Length];
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
