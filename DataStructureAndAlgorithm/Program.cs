﻿ namespace DataStructureAndAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs\n 1.Binary search");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch binarysearch = new BinarySearch();
                        binarysearch.Search(@"C:\Users\Lenovo\Desktop\Git\DataStructureAndAlgorithm\DataStructureAndAlgorithm\Word.txt");
                        break;
                }
            }
        }
    }
}