using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    //Declare Delegate
    public delegate bool ConditionFuncDeligate(int A, int B);
    internal class SortingAlgorithms

    {
        public static void BubbleSort(int[] Arr , ConditionFuncDeligate refrence)
        {
            if(Arr is not null)
            {
                for(int i = 0; i < Arr.Length; i++)
                {
                    for(int j = 0; j< Arr.Length -1 ; j++)
                    {
                        if (refrence.Invoke(Arr[j] , Arr[j + 1])) 
                        { 
                            
                        
                            Swap(ref Arr[j], ref Arr[j+1]);

                        }

                    }

                }
            }
        }
        //public static void BubbleSort(string[] Arr, ConditionFuncDeligate refrence)
        //{
        //    if (Arr is not null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - 1; j++)
        //            {
        //                if (refrence.Invoke(Arr[j], Arr[j + 1]))
        //                {


        //                    Swap(ref Arr[j], ref Arr[j + 1]);

        //                }

        //            }

        //        }
        //    }
        //}

        //public static void BubbleSortAscending(int[] Arr, ConditionFuncDeligate refrence)
        //{
        //    if (Arr is not null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - 1; j++)
        //            {
        //                if (refrence.Invoke(Arr[j], Arr[j + 1]))
        //                {


        //                    Swap(ref Arr[j], ref Arr[j + 1]);

        //                }

        //            }

        //        }
        //    }
        //}

        //public static void BubbleSortDescending(int[] Arr)
        //{
        //    if (Arr is not null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - 1; j++)
        //            {
        //                if (Arr[j] < Arr[j + 1])

        //                {
        //                    Swap(ref Arr[j], ref Arr[j + 1]);

        //                }

        //            }

        //        }
        //    }
        //}


        public static void Swap(ref int X ,ref int Y)
        {
            int temp = X;
            X = Y;
            Y = temp;


        }
    }

    class SortingFunctions
    {
        public static bool CompareGtr(int L, int R)
        {
            return L < R;
        }

        public static bool CompareLess(int L, int R)
        {
            return L > R;
        }

    }
}
