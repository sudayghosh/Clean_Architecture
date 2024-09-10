using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (var j = 0; j < n; j++)
            {
                nums1[m + j] = nums2[j];
            }

            int k = nums1.Length - 1;
            do
            {
                int n1 = nums1[k];
                if (k - 1 >= 0 && n1 < nums1[k - 1])
                {
                    nums1[k] = nums1[k - 1];
                    nums1[k - 1] = n1;
                    k = nums1.Length;
                }
                k--;
            } while (k >= 0);
        }

        public int MySqrt(int num = 4)
        {
            if (0 == num) { return 0; }
            int n = (num / 2) + 1;
            int n1 = (n + (num / n)) / 2;
            while (n1 < n)
            {
                n = n1;
                n1 = (n + (num / n)) / 2;
            }
            return n;
        }

        public string AddBinary(string a = "1111", string b = "1111")
        {
            if (a.Length > b.Length)
            {
                b = b.PadLeft(a.Length, '0');
            }
            if (a.Length < b.Length)
            {
                a = a.PadLeft(b.Length, '0');
            }

            bool remaining = false;
            string result = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                int aa = a[i] - '0';
                int bb = b[i] - '0';
                int sum = Convert.ToInt16((aa.ToString() + bb.ToString())) / 10;
                //if (remaining)
                //{
                //    sum = Convert.ToInt16((aa.ToString() + bb.ToString()));
                //}
                if (sum == 1)
                {
                    if (!remaining)
                    {
                        result += "1";
                    }
                    else if (remaining)
                    {
                        sum = (sum + 1) % 10;
                        if (sum == 2)
                        {
                            result += "1";
                            remaining = true;
                        }
                        else if (sum == 0)
                        {

                        }
                    }
                }
                else
                {
                    if (remaining)
                    {
                        sum += 1;
                    }
                    if (sum == 1)
                        result += "0";
                    else
                    {
                        result += sum.ToString();
                        remaining = false;
                    }
                }
            }

            if (remaining)
                result += "1";

            string reverse = "";
            for (int i = result.Length - 1; i > -1; i--)
            {
                reverse += result[i];
            }

            return reverse;
        }

        public int[] PlusOne(int[] digits)
        {
            digits = [8, 9];
            int[] output = new int[digits.Length + 1];

            bool remaining = false;

            var start = output.Length - 1;

            if (Convert.ToInt32(digits[digits.Length - 1]) > 8)
            {
                output[digits.Length - 1] = 1;
                remaining = true;
                start = start - 2;
            }

            for (int i = start; i >= 0; i--)
            {
                if (Convert.ToInt32(digits[i]) > 8)
                {
                    if (remaining)
                    {
                        output[i] = 0;
                        remaining = true;
                    }
                    else
                    {
                        output[i] = digits[i];
                        remaining = false;
                    }
                }
                else
                {
                    output[i] = digits[i];
                    if (remaining)
                    {
                        remaining = false;
                    }
                }
            }
            //if (remaining)
            //{
            //    output[0] = 1;
            //}


            //var total = Convert.ToInt32(digitMerged) + 1;

            //int lastDigit = digits[digits.Length - 1];
            //if (lastDigit >= 9)
            //{
            //    output = new int[total.ToString().Length];

            //    for (int i = 0; i < total.ToString().Length; i++)
            //    {
            //        output[i] = total.ToString()[i] - '0';
            //    }
            //}
            //else
            //{
            //    digits[digits.Length - 1] = lastDigit + 1;
            //    output = digits;
            //}
            return output;
        }

        public int LengthOfLastWord(string s = "   to   the moon  ")
        {
            int k = 0;
            string lastWord = string.Empty;
            s = s.Trim();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    lastWord = "";
                    continue;
                }
                lastWord += s[i];
            }
            return lastWord.Length;
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
