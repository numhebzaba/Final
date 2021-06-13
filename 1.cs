using System;

namespace FinalCoding_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] table = new int[3, 3];
            int zero_i = 0;
            int zero_j = 0;

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = int.Parse(Console.ReadLine()); //ผู้ใช้กรอกข้อมูลถูกต้อง
                    if (table[i, j] == 0)
                    {
                        zero_i = i;
                        zero_j = j;
                    }
                }
            }

            table[zero_i, zero_j] = int.Parse(Console.ReadLine());

            int sameNumber = 0;
            if (table[zero_i, zero_j] == table[0, zero_j])
                sameNumber++;
            if( table[zero_i, zero_j] == table[1, zero_j])
                sameNumber++;
            if (table[zero_i, zero_j] == table[2, zero_j])
                sameNumber++;
            if (table[zero_i, zero_j] == table[zero_i, 0])
                sameNumber++;
            if (table[zero_i, zero_j] == table[zero_i, 1])
                    sameNumber++;
            if (table[zero_i, zero_j] == table[zero_i, 2])
                sameNumber++;


            if (sameNumber>2)
            {
                Console.WriteLine("The number is available");
            }
            else
            {
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        Console.Write(table[i, j]);
                    }
                    Console.WriteLine("");
                }
            }

        }
    }
}
