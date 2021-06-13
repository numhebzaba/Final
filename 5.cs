using System;

namespace FinalCoding_5
{
    class Program
    {
        struct Inventory
        {
            public string itemName;
            public string category;

        }

        static void Main(string[] args)
        {
            int numberOfItem = int.Parse(Console.ReadLine());
            Inventory[] itemArray = new Inventory[numberOfItem];

            for(int i =0; i < numberOfItem; i++)
            {
                itemArray[i].itemName = Console.ReadLine();
                itemArray[i].category = Console.ReadLine();
            }

            while(true)
            { 
                string modeOfFinding = Console.ReadLine();
                bool categoryCheck;
                for (int i = 0; i < numberOfItem; i++)
                {
                    if (modeOfFinding == itemArray[i].category)
                    {
                        categoryCheck = true;
                    }
                        
                }

                if (modeOfFinding == "ShowAll")
                {
                    for (int i = 0; i < numberOfItem; i++)
                    {
                        Console.WriteLine(itemArray[i].itemName);
                        Console.WriteLine(itemArray[i].category);
                        Console.WriteLine("");
                    }
                }else if(categoryCheck =true)
                {
                    for (int i = 0; i < numberOfItem; i++)
                    {
                        if (modeOfFinding == itemArray[i].category)
                        {
                            Console.WriteLine(itemArray[i].itemName);
                            Console.WriteLine("");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("End");
                    break;
                }
            }
        }
    }
}
