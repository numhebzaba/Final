using System;

namespace FinalCoding_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = double.NegativeInfinity;
            double Min = double.PositiveInfinity;
            double sum = 0;
            
            double[] numberArray = new double[0];
            while (true)
            {
                //bool checknumber = double.TryParse(Console.ReadLine(), out numberArray[numberArrayIndex - 1]);
                double inputNumber;
                //double inputNumber = double.Parse(Console.ReadLine());
                bool checknumber = double.TryParse(Console.ReadLine(), out inputNumber);

                double[] newNumberArray = new double[numberArray.Length + 1];
                for (int i = 0; i < numberArray.Length; i++)
                {
                    newNumberArray[i] = numberArray[i];
                }
                newNumberArray[newNumberArray.Length - 1] = inputNumber;
                numberArray = newNumberArray;

               
                if (checknumber == false)//ผู้ใช้กรอก End
                {
                    while (true)
                    {
                        string mode = Console.ReadLine();
                        if (mode == "FindMax")
                        {
                            for(int i = 0;i < numberArray.Length; i++)
                            { 
                                if (numberArray[i] > max)
                                max = numberArray[i];
                            }
                            Console.WriteLine(max);
                            break;
                        }
                        else if (mode == "FindMin")
                        {
                            for (int i = 0; i < numberArray.Length; i++)
                            {
                                if (numberArray[i] < Min)
                                    Min = numberArray[i];
                                
                            }
                            Console.WriteLine(Min);
                            break;
                        }
                        else if (mode == "FindMean")
                        {
                            for(int i = 0; i< numberArray.Length; i++)
                            {
                                sum += numberArray[i];
                                
                            }
                            Console.WriteLine(sum / numberArray.Length);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid mode");
                        }
                    }
                    break;
                }
                

            }
            

        }
    }
}
