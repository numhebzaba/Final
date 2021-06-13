using System;

namespace FinalCoding_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMemberInArray = int.Parse(Console.ReadLine());
            int[] intArray = new int[numberOfMemberInArray];
            for(int i = 0; i < numberOfMemberInArray; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("bubble sort");
            for (int loop = numberOfMemberInArray-1; loop >0; loop--)
            {
                for (int i = 0; i < loop; i++)
                {
                        SwaapfHigher(ref intArray[i],ref intArray[i + 1]);
                }
            }
            for (int i = 0; i < numberOfMemberInArray; i++)
            {
                Console.Write("{0}",intArray[i]);
            }



        }
        static void Swap(ref int a, ref int b)
        {
                int temp = a;
                a = b;
                b = temp;
        }
        static void SwaapfHigher(ref int a, ref int b)
        {
            if (a > b)
            {
                Swap(ref a,ref b);
            }
        }
    }
}
