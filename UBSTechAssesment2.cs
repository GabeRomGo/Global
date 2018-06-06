using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] records = GetInts();
            int[] sortedRecords;
            if (records.Length >= 100) 
            {
                sortedRecords = SortRecords(records, "Merge");                
            }
            else
            {
                sortedRecords = SortRecords(records, "Insertion");              
            }

            Console.WriteLine("There are {0} sorted records", sortedRecords.Length);
            for (int i = 0; i < sortedRecords.Length; i++)
            {
                var shiftedValue = sortedRecords[i] * 10;
                Console.WriteLine("The shifted value at position {0} is {1}", i, shiftedValue);
            }
        }

        private static int[] GetInts()
        {
            // implementation is not relevant
            throw new NotImplementedException();
        }

        private static int[] SortRecords(int[] records, string sortAlgorithm)
        {
            // implementation is not relevant
            throw new NotImplementedException();
        }
    }
}
