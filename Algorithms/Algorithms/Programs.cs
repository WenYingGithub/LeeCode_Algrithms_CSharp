using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsole
{
    class Program
    {
        static void Main()
        {
            Solutions solution = new Solutions();

            #region history

            //167
            //var response = solution.TwoSum();

            //744
            //var result = solution.FindSmallestLetterGreaterThanTarget();

            //349
            //solution.IntersectionofTwoArrays();      
            #endregion history

            //350
           int[] response1 = solution.IntersectionofTwoArraysII();
        }
    }

    public class Algorithm
    {
        public bool BinarySearch_AscendingSorted_NonDuplicate_Arrary(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid]) return true; 

                if (key < inputArray[mid]) max = mid - 1;                
                else min = mid + 1;              
            }
            return false;
        }

        public int BinarySearch_Sorted_WithDuplicate_Arrary(char[] inputArray, char key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    if (mid < inputArray.Length - 1 && inputArray[mid] == inputArray[mid + 1])
                    {
                        min = mid + 1;
                    }
                    else 
                    { 
                        return ++mid; 
                    } 
                }
                else if (key < inputArray[mid]) { max = mid - 1;}
                else { min = mid + 1;}
            }
            return min;
        }

        public object TwoSumProblem_Sorted_WithDuplicate_Arrary(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    if ( mid < inputArray.Length -1 && inputArray[mid] == inputArray[mid + 1])
                    {
                        min = mid + 1;
                    }
                    else
                    {
                        return ++mid;
                    }
                }
                else if (key < inputArray[mid]) { max = mid - 1; }
                else { min = mid + 1; }
            }
            return null;
        }
    }

    public class Solutions 
    {
        public object TwoSum() {
            Algorithm algorithm = new Algorithm();

            int[] numbers = new int[] {-1,0};
            int target = -1;
            int len = numbers.Length;

            for (int i = 0; i <= len; i++)
            {
                int x = target - numbers[i];

                var found = algorithm.TwoSumProblem_Sorted_WithDuplicate_Arrary(numbers, x);

                if(found != null && Convert.ToInt32(found)!=i)
                {
                    return new int[] { i+1, Convert.ToInt32(found)};
                }
            }
            return null;
        }

        public char FindSmallestLetterGreaterThanTarget()
        {
            Algorithm algorithm = new Algorithm();

            char[] letters = new char[] {'e','e','e','e','e','e','n','n','n','n'};
            char target = 'e';

            int length = letters.Length;
            if (target >= letters[length - 1] || target < letters[0]) return letters[0];

            int found = algorithm.BinarySearch_Sorted_WithDuplicate_Arrary(letters, target);
            if (letters[found] < target) return letters[found-1];
            else return letters[found];           
        }

        public void IntersectionofTwoArrays()
        {
            Algorithm algorithm = new Algorithm();
            int[] nums1 = new int[] { 2, 1, 2, 2, 2 };
            int[] nums2 = new int[] { 1, 1, 8, 5, 5, 5 };
          
            HashSet<int> result = new HashSet<int>();
            HashSet<int> distictNums1 = new HashSet<int>(nums1);
            HashSet<int> distictNums2 = new HashSet<int>(nums2);

            HashSet<int> longArrary = (distictNums1.Count >= distictNums2.Count) ? distictNums1 : distictNums2;
            HashSet<int> shortArrary = (distictNums1.Count >= distictNums2.Count) ? distictNums2 : distictNums1;

            int[] sotredLongArrary = longArrary.OrderBy(x => x).ToArray();
            
            foreach (int s in shortArrary)
            {
                if (algorithm.BinarySearch_AscendingSorted_NonDuplicate_Arrary(sotredLongArrary, s)) result.Add(s);
            }

            var response = result.ToArray();
        }

        public int[] IntersectionofTwoArraysII()
        {
            Algorithm algorithm = new Algorithm();
            int[] nums1 = new int[] { 3, 2, 1 };
            int[] nums2 = new int[] { 1, 1 };
          
            List<int> result = new List<int>();

            int[] longArrary = (nums1.Length >= nums2.Length) ? nums1 : nums2;
            int[] shortArrary = (nums1.Length >= nums2.Length) ? nums2 : nums1;

            Array.Sort(longArrary);

            foreach (int s in shortArrary)
            {
                if (algorithm.BinarySearch_AscendingSorted_NonDuplicate_Arrary(longArrary, s)
                    && result.Where(x => x == s).Count() < longArrary.Where(x => x == s).Count()
                    ) result.Add(s);
            }

            return result.ToArray();
        }
    }
}
