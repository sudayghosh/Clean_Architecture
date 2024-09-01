using System;

namespace SecondInterviewRelliSource
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public int LengthOfLastWord(string s = "Hello World")
        {
            int k = -1;

            return k;
        }

        public int StrStr(string haystack = "sadbutsad", string needle = "sad")
        {
            int k = -1;
            for (int i = 0; i < haystack.Length; i++)
            {
                int len = needle.Length;
                if (i + len > haystack.Length)
                    len = haystack.Length - i;
                if (haystack.Substring(i, len) == needle)
                {
                    k = i;
                    break;
                }
            }
            return k;
        }

        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }

        public int RemoveDuplicates(int[] nums)
        {
            int k = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[k] != nums[i])
                {
                    k++;
                    nums[k] = nums[i];
                }
            }
            return k + 1;
        }

        ListNode output = new ListNode(0);

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            if (list1.val <= list2.val)
            {
                //output.next = new ListNode(list1.val);
                //output = new ListNode(list1.val, list1.next);
                output.val = list1.val;
                output.next = MergeTwoLists(list2, list1.next);
                //return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
            return output;
        }

        public int RomanToInt(string s) //"MCMXCIV"
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            keyValuePairs.Add("I", 1);
            keyValuePairs.Add("V", 5);
            keyValuePairs.Add("X", 10);
            keyValuePairs.Add("L", 50);
            keyValuePairs.Add("C", 100);
            keyValuePairs.Add("D", 500);
            keyValuePairs.Add("M", 1000);

            var output = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                var currentRomanVal = keyValuePairs.FirstOrDefault(f => f.Key == s[i].ToString());
                var val = currentRomanVal.Value;

                if (i - 1 >= 0)
                {
                    var prevRoman = s[i - 1].ToString();
                    var prevRomanVal = keyValuePairs.FirstOrDefault(f => f.Key == prevRoman);

                    if (prevRomanVal.Value < currentRomanVal.Value)
                    {
                        val = currentRomanVal.Value - prevRomanVal.Value;
                        i--;
                    }
                }

                output += val;
            }
            return output;
        }

        public bool IsPalindrome(int x)
        {
            bool result = false;

            string reverseX = "";
            for (int i = x.ToString().Length - 1; i >= 0; i--)
            {
                reverseX += x.ToString()[i];
            }
            //int reverseX = 0, tempX = x;
            //do
            //{
            //    var lastDigit = tempX % 10;
            //    reverseX = (reverseX * 10) + lastDigit;
            //    tempX = tempX / 10;
            //} while (tempX != 0);

            if (reverseX == x.ToString())
                result = true;

            return result;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] results = new int[2];

            int startIndex = 0;
            bool isMatch = true;
            int start = nums[startIndex];
            results[0] = startIndex;

            int i = startIndex + 1;
            do
            {
                if (start + nums[i] == target)
                {
                    results[1] = i;
                    isMatch = false;
                }
                i++;
                if (isMatch && nums.Length == i)
                {
                    startIndex++;
                    results[0] = startIndex;
                    start = nums[startIndex];
                    i = startIndex + 1;
                }
            }
            while (isMatch);
            return results;
        }
    }
}
