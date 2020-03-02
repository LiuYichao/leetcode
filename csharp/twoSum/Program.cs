using System;
using System.Collections.Generic;
using System.Linq;

namespace twoSum
{
    class TwoSum
    {
        public int[] bruteForce(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }
            throw new Exception("No two sum solution");
        }

        public int[] twoPassHashTable(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dic.TryGetValue(complement, out index) && index != i)
                {
                    return new int[] { index, i };
                }

            }
            throw new Exception("No two sum solution");
        }


        public int[] onePassHashTable(int[] nums, int target)
        {

            Dictionary<int, int> dic = new Dictionary<int, int>();
            int complement = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                complement = target - nums[i];
                if (dic.ContainsKey(complement))
                {
                    return new int[] { i, dic[complement] };
                }
                else
                {
                    dic[nums[i]] = i;
                }
            }
            throw new Exception("No two sum solution");
        }
    }
}
