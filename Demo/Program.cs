namespace Demo
{
    //Class
    //struct
    //Interface
    //Enum

    //step 0: Declare Delegate

    public delegate int StringFunDelegate(string str);
    //NEW Delegate(class) , Refrence From Delegate can refer to function or more (pointer to functions)
    //These function must have the same signature of the delegate :
    //int(string)
    //Regardless Function Naming[Function Name or the parameter] , Access Modifier
    internal class Program
    {
        //Delegate : c# Language Feature
        //pure OOP
        //Usage: 
        //1. functional programing
        //2. Event-Driven Programing
        // Java - Pure OOP
        static void Main(string[] args)
        {
            #region Delegate
            //step 01: Declare Refrence From Type StringFucDelegate[Delegate]

            //StringFunDelegate X = StringFunctions.GetCountOfUpperCaseChars; //Syntax sugar

            ////X = StringFunctions.GetCountOfLowerCaseChars;

            //X += StringFunctions.GetCountOfLowerCaseChars;

            ////Step 02: Use [Function] throught the function

            ////int Result = X.Invoke("Hello World");
            //int Result = X("Hello World"); //Sybtax sugar

            //Console.WriteLine(Result);
            #endregion

            //    int[] Numbers = { 9,8,7,6,5,4,3,2,1};

            //    //SortingAlgorithms.BubbleSort(Numbers ,SortingFunctions.CompareGtr); //descending
            //    SortingAlgorithms.BubbleSort(Numbers, SortingFunctions.CompareLess); //Ascending
            //    foreach (int n in Numbers) 
            //    { 
            //        Console.Write(n + " ");


            //    }


            //    //SortingAlgorithms.BubbleSort(Numbers);
            //    //foreach (int n in Numbers)
            //    //{
            //    //    Console.Write(n + " ");



            //}

            string[] Names = { "Ahmed", "Mahmoud", "Ali", "Mariam" };

            //SortingAlgorithms.

        }





    }

    #region Delegate
    class StringFunctions
    {

        public static int GetCountOfUpperCaseChars(string Word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(Word))
            {
                for (int i = 0; i < Word.Length; i++)
                {
                    if (char.IsUpper(Word[i]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int GetCountOfLowerCaseChars(string Word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(Word))
            {
                for (int i = 0; i < Word.Length; i++)
                {
                    if (char.IsLower(Word[i]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
    #endregion
}

