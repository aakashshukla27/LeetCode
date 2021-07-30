using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class TwoSum
    {
        public int[] TwoSumSolution(int[] nums, int target)
        {
            HashSet<int> hash = new HashSet<int>();
            int[] returnArray = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                if (hash.Contains(temp))
                {
                    returnArray[0] = temp;
                    returnArray[1] = nums[i];
                    break;
                }
                hash.Add(nums[i]);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if(returnArray[0] == nums[i])
                {
                    returnArray[0] = i;
                    break;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (returnArray[1] == nums[i] && returnArray[0] != i)
                {
                    returnArray[1] = i;
                    break;
                }
            }

            return returnArray;
        }

        public int[] TwoSumSolution2(int[] nums, int target)
        {
            Hashtable valuePairs = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {

                int complement = target - nums[i];
                if (valuePairs.ContainsKey(complement))
                {
                    return new int[] { (int)valuePairs[complement], i };
                }
                else
                {
                    if (!valuePairs.ContainsKey(nums[i]))
                    {
                        valuePairs.Add(nums[i], i);
                    }
                }


            }
            return null;
        }
    }
}
