using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    public class BinarySearch
    {
        public void Search(string filepath)
        {
            string data = File.ReadAllText(filepath);
            string[] words = data.Split(",");
            Console.WriteLine("Enter words to search");
            string search = Console.ReadLine();
            foreach (var item in words)
            {
                if (search.ToLower().Equals(item.ToLower()))
                {
                    Console.WriteLine("words found");
                    return;
                }
            }
            Console.WriteLine("words not found");
        }
    }
}
