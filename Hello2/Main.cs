using System.ComponentModel;

namespace mba.Hello
{
    public class Main
    {
        public bool IsPositive(int i)
        {
            return i > 0;
        }

        public int E1_Multiples_of_3_or_5(int max_num)
        {
            int total = 0;
            for (int i = 1; i < max_num; i++)
            {
                bool mod_3 = i % 3 == 0;
                bool mod_5 = i % 5 == 0;
                if (mod_3 || mod_5)
                {
                    total += i;
                }
            }
            return total;
        }

        public int E2_Even_Fibonacci_Numbers(int max_num)
        {
            int total = 2;
            int a = 1;
            int b = 2;
            int curr;
            while (a + b < max_num)
            {
                curr = a + b;
                bool curr_is_even = curr % 2 == 0;
                if (curr_is_even)
                {
                    total += curr;
                }
                a = b;
                b = curr;
            }
            return total;
        }
        public long E3_Largest_Prime_Factor(long large_num)
        {
            long curr_val = large_num;
            long candidate = 2;
            while (curr_val > 1)
            {
                if (curr_val % candidate == 0)
                    curr_val = curr_val / candidate;
                if (curr_val > 1) // we have found our winner
                    candidate++;
            }
            if (candidate > 7000)
            {
                throw new Exception("Houston we have a problem");
            }
            return candidate;
        }

        public List<int> GetPrimesLessThanCandidate(List<int> primes, int candidate)
        {
            if (candidate < 2)
                throw new ArgumentException("candidate number must be greater than 2");
            if (candidate < 2)
                return primes;
            for (int i = 2; i <= candidate; i++)
            {
                bool is_prime = true;
                bool prime_in_list = false;
                for (int j = 0; j < primes.Count; j++)
                {
                    if (i % primes[j] == 0)
                    {
                        if (primes[j] == candidate) 
                            prime_in_list = true;
                        is_prime = false;
                        break;
                    }
                }
                if (prime_in_list)
                    break;
                if (is_prime)
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        public bool IsPalindrome(long candidate)
        {
            string strCand = candidate.ToString();
            string first;
            string last;
            int strCandLen;
            while (strCand.Length > 0)
            {
                if (strCand.Length == 1)
                    break; // a single char is it's own mirror
                first = strCand[0].ToString();
                strCandLen = strCand.Length;
                last = strCand[strCandLen - 1].ToString();
                if (first != last)
                    return false;
                strCand = strCand.Substring(1, strCandLen - 2);
            }

            return true;
        }

        public long E04_GetLargestPalindromeByDigitCount(int digit_count)
        {
            int min = int.Parse("1" + new string('0', digit_count - 1));
            int max = int.Parse(new string('9', digit_count));
            int a, b;
            int largest_product = -1;
            int candidate;
            bool isPalindrome;
            for (a = min; a <= max; a++)
            {
                for (b = min; b <= max; b++)
                {
                    candidate = a * b;
                    isPalindrome = this.IsPalindrome(candidate);
                    if (isPalindrome && candidate > largest_product)
                    {
                        largest_product = candidate;
                    }
                }
            }
            return largest_product;
        }

        public long E05_GetSmallestMultiple(int max)
        {
            bool will_divide_evenly = false;
            long candidate = 2;
            while (!will_divide_evenly)
            {
                for (long i = 2; i <= max; i++)
                {
                    bool local_true = true;
                    if(candidate % i != 0)
                    {
                        candidate++;
                        local_true = false;
                        break;
                    }
                    if (i == max && local_true)
                        will_divide_evenly = true;
                }

            }
            return candidate;
        }

    }
}
