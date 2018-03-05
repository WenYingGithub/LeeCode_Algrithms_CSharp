using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Programs
    {
        static void Main()
        {
             Algorithm algorithm = new Algorithm();
            Solutions solution = new Solutions();

            //744
            solution.FindSmallestLetterGreaterThanTarget();

            //349
            solution.IntersectionofTwoArrays();   
            
            Console.WriteLine("Input the Problem Number to begin: \r\n\r\n Problem Number : ");

            int problemNumber = Convert.ToInt32( Console.ReadLine());

            string outPut = "";

            switch (problemNumber)
            {
                case 349:
                    Solutions hi = new Solutions();
                    outPut = hi.hrrrr();
                    break;

                default:
                    outPut = "The End";
                    break;

            }
            Console.WriteLine("\r\n\r\nResult: " + outPut);
            Console.ReadKey();
        }

    }
    
        public class Algorithm
    {
        public bool BinarySearchOnSortedArrary(int[] inputArray, int key)
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

        public object BinarySearchOnSortedArrary_Index(char[] inputArray, char key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid]) return ++mid;

                if (key < inputArray[mid]) max = mid - 1;
                else min = mid + 1;
            }
            return null;
        }
    }


    public class Solutions 
    {
        public void FindSmallestLetterGreaterThanTarget()
        {
            Algorithm algorithm = new Algorithm();


            char[] letters = new char[] {'c', 'f', 'j'};
            char target = 'd';
            char result = target;

            var found = algorithm.BinarySearchOnSortedArrary_Index(letters, target);
            if (found == null) 
            { 
                result = target; 
            }
            else 
            {
                result = letters[Convert.ToInt32(found)+1];
            }
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
                if (algorithm.BinarySearchOnSortedArrary(sotredLongArrary, s)) result.Add(s);
            }

            var response = result.ToArray();
        }
    
    }
}
