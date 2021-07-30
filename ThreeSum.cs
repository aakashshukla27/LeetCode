using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ThreeSum
    {
        public IList<IList<int>> ThreeSumSolution(int[] nums)
        {
            if(nums.Length == 0 || nums.Length < 3)
            {
                return new List<IList<int>>();
            }
            Array.Sort(nums);
            IList<IList<int>> returnList = new List<IList<int>>();
            if (nums[0] == 0 && nums[nums.Length - 1] == 0)
            {
                List<int> ll = new List<int>();
                ll.Add(0);
                ll.Add(0);
                ll.Add(0);
                returnList.Add(ll);
                return returnList;

            }
            
            for(int i=0; i<nums.Length - 2; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;
                while(j < k)
                {
                    if((nums[i] + nums[j] + nums[k] == 0) && ((i != j) && (j != k) && (i != k))){
                        var temp = new List<int>();
                        temp.Add(nums[i]);
                        temp.Add(nums[j]);
                        temp.Add(nums[k]);
                        returnList.Add(temp);
                      
                        j++;
                       
                    }
                    else if(nums[i] + nums[j] + nums[k] < 0)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }
            }

          

            var distinctlist = returnList.Select(o =>
            {
                var t = o.OrderBy(x => x).Select(i => i.ToString());
                return new { Key = string.Join("", t), List = o };
            })
                .GroupBy(o => o.Key)
                .Select(o => o.FirstOrDefault())
                .Select(o => o.List);
            IList<IList<int>> ret = new List<IList<int>>();

            foreach (var item in distinctlist)
            {
                ret.Add(item);
            }

            return ret;
        }
    }
}
