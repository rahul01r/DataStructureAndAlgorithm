 namespace DataStructureAndAlgorithm
 {
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs\n 1.Binary search\n 2.Bubble sort\n 3.Insertion Sort\n 4.Merge Sort\n 5.Anagram\n 6.Print prime number\n 7.Check Prime number is Anagram and Palindrome");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch binarysearch = new BinarySearch();
                        binarysearch.Search(@"C:\Users\Lenovo\Desktop\Git\DataStructureAndAlgorithm\DataStructureAndAlgorithm\Word.txt");
                        break;
                    case 2:
                        BubbleSort bubblesort = new BubbleSort();
                        bubblesort.Sort(@"C:\Users\Lenovo\Desktop\Git\DataStructureAndAlgorithm\DataStructureAndAlgorithm\Word.txt");
                        break;
                    case 3:
                        InsertionSort insertionsort = new InsertionSort();
                        insertionsort.Insertion();
                        break ;
                    case 4:
                        MergeSort mergeSort = new MergeSort();
                        int n = 8;
                        int[] array = { 49, 3, 53, 21, 27, 75, 50, 41 };
                        Console.WriteLine("Merge Sort");
                        Console.Write("Initial array is: ");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(array[i] + " ");
                        }
                        mergeSort.Sort(array, 0, n - 1);
                        Console.Write("\nSorted Array is: ");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(array[i] + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        Anagram anagram = new Anagram();
                        anagram.AnagramWord("heart", "earth");
                        break;
                    case 6:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.Prime();
                        break;
                    case 7:
                        Palindrome palindrome = new Palindrome();
                        palindrome.Anagram();
                        palindrome.PrimeNumber();
                        palindrome.PalindromeNum();
                        break;
                }
            }
        }
    }
 }