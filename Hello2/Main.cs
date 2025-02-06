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
            int first = 0;
            int last = strCand.Length - 1;
            while (first < last)
            {
                //if (strCand[first] != strCand[last]) return false;
                //else
                //{
                //    first++;
                //    last--;
                //}
                if (strCand[first] == strCand[last])
                {
                    first++;
                    last--;
                }
                else return false;
            }
            return true;

            //string strCand = candidate.ToString();
            //string first;
            //string last;
            //int strCandLen;
            //while (strCand.Length > 0)
            //{
            //    if (strCand.Length == 1)
            //        break; // a single char is it's own mirror
            //    first = strCand[0].ToString();
            //    strCandLen = strCand.Length;
            //    last = strCand[strCandLen - 1].ToString();
            //    if (first != last)
            //        return false;
            //    strCand = strCand.Substring(1, strCandLen - 2);
            //}

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
                    if (candidate % i != 0)
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

        public int E06_a_SumOfTheSquares(int max)
        {
            int total = 0;
            for (int i = 0; i <= max; i++)
            {
                total += i * i;
            }
            return total;
        }

        public int E06_b_SquareOfTheSums(int max)
        {
            int total = 0;
            for (int i = 0; i <= max; i++)
            {
                total += i;
            }
            total *= total;
            return total;
        }

        public int E06_c_SumSuareDifference(int max)
        {
            int square = E06_b_SquareOfTheSums(max);
            int sum = E06_a_SumOfTheSquares(max);
            int result = square - sum;
            return result;
        }

        public int E07_a_GetNthPrime_Works(int max)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int candidate = 2;
            while (primes.Count < max)
            {
                candidate++;
                bool isPrime = true;
                foreach (int prime in primes)
                {
                    if (candidate % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) primes.Add(candidate);
            }
            int retval = primes[max - 1];
            return retval;
        }

        public long E08_a_GetLargestProductInSeries(string sequenceOfNumbers, int numOChars)
        {
            long winner = 0;
            int lenOString = sequenceOfNumbers.Length;
            for (int i = 0; i <= lenOString - numOChars; i++)
            {
                long localTotal = 1;
                int start = i;
                int end = i + numOChars;
                for (int j = start; j < end; j++)
                {
                    localTotal *= int.Parse(sequenceOfNumbers.Substring(j, 1));
                }
                if (localTotal > winner) winner = localTotal;
            }
            return winner;
        }



        public int[] E09_a_FindSpecialPythagoreanTriplet(int target)
        {
            int[] retval = new int[4];
            double ftarget = (double)target;
            int a = 0, b = 0, c_int = 0;
            double c_squared = (double)0.0;
            double c = (double)0.0;
            bool isTarget = false;
            for (a = 3; a < target; a++)
            {
                for (b = a + 1; b < target; b++)
                {
                    c_squared = a * a + b * b;
                    c = Math.Sqrt(c_squared);
                    if (a + b + Math.Ceiling(c) > ftarget) break;
                    bool cIsAWholeNumber = (c % 1) < double.Epsilon;
                    if (cIsAWholeNumber)
                    {
                        c_int = (int)c;
                        int sumOfSides = a + b + c_int;
                        isTarget = (sumOfSides == target);
                        retval = new int[4] { (a * b * c_int), a, b, c_int };
                        //Console.WriteLine($"A = {retval[1]}, B = {retval[2]}, C = {retval[3]}, total = {retval[0]}");
                        if (isTarget) break;
                    }
                }
                if (isTarget) break;
            }
            return retval;
        }

        public bool SEL_01_findintarget(string source, string target)
        {
            bool foundit = false;
            int endBuffer = source.Length - target.Length;
            for (int i = 0; i < endBuffer; i++)
            {
                bool workssofar = true;
                for (int j = i; j < i + target.Length - 1; j++)
                {
                    string s = source[i + j].ToString();
                    string t = target[j].ToString();
                    if (s != t)
                    {
                        workssofar = false;
                        break;
                    }
                }
                if (workssofar)
                {
                    foundit = true;
                    break;
                }
            }
            return foundit;
        }

        public List<int> E10_a_GetAllPrimesBelow(int max)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            primes.Add(3);
            int current = 3;
            while (current < max)
            {
                bool isPrime = true;
                current += 2;
                //Console.WriteLine($"processing current = {current} of {max} = {current / max * 100}");
                for (int i = 0; i < primes.Count; i++)
                {
                    if (current % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) primes.Add(current);
            }
            return primes;
        }

        public long E10_b_GetSumOfIntList(List<int> primes)
        {
            long sum = 0;
            foreach (int i in primes) sum += (long)i;
            return sum;
        }

        public int[,] E11_a_ConvertStringToIntGrid(string myString, int rows, int columns)
        {
            string[] rawString = myString.Split(' ');
            int[] rawInts = Array.ConvertAll(rawString, s => int.Parse(s));
            int[,] retval = new int[rows, columns];
            int cursor = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    retval[i, j] = rawInts[cursor++];
            return retval;
        }

        public int E11_b_GetLargestHorizontalProductFromGrid(int[,] grid)
        {
            int rows = grid.GetLength(0);
            int columns = grid.GetLength(1);
            int winner = 0;
            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < columns - 1; j++)
                {
                    int candidate = grid[i, j] * grid[i, j + 1];
                    if (candidate > winner)
                        winner = candidate;
                }
            return winner;
        }

        public int E11_c_GetLargestVerticleProductFromGrid(int[,] grid)
        {
            int rows = grid.GetLength(0);
            int columns = grid.GetLength(1);
            int winner = 0;
            for (int i = 0; i < rows - 1; ++i)
                for (int j = 0; j < columns; j++)
                {
                    int candidate = grid[i, j] * grid[i + 1, j];
                    if (candidate > winner)
                        winner = candidate;
                }
            return winner;
        }

        public int E11_d_GetLargestDiagonalProductFromGrid(int[,] grid)
        {
            int rows = grid.GetLength(0);
            int columns = grid.GetLength(1);
            int winner = 0;
            for (int i = 0; i < rows - 1; ++i)
                for (int j = 0; j < columns; j++)
                {
                    int diagBack = 0;
                    int diagForward = 0;
                    if (j > 0)
                        diagBack = grid[i, j] * grid[i + 1, j - 1];
                    if (j < columns - 1)
                        diagForward = grid[i, j] * grid[i + 1, j + 1];
                    if (diagBack > winner)
                        winner = diagBack;
                    if (diagForward > winner)
                        winner = diagForward;
                }
            return winner;
        }



        public int E11_e_GetLargestProductFromGrid_Len2(int[,] grid, int length)
        {
            int rows = grid.GetLength(0);
            int columns = grid.GetLength(1);
            int winner = 0;
            int buffer = length - 1;
            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < columns; j++)
                {
                    int diagBack = 1;
                    int diagForward = 1;
                    int horizontal = 1;
                    int vertical = 1;
                    bool isHighEnough = (i < rows - buffer);
                    bool isRightEnough = (j >= buffer);
                    bool isLeftEnough = (j < columns - buffer);
                    for (int offset = 0; offset < length; offset++)
                    {
                        if (isHighEnough)
                            vertical *= grid[i + offset, j];
                        if (isLeftEnough)
                            horizontal *= grid[i, j + offset];
                        if (isRightEnough && isHighEnough)
                            diagBack *= grid[i + offset, j - offset];
                        if (isLeftEnough && isHighEnough)
                            diagForward *= grid[i + offset, j + offset];
                    }
                    List<int> candidates = new List<int>();
                    candidates.Add(vertical);
                    candidates.Add(horizontal);
                    candidates.Add(diagBack);
                    candidates.Add(diagForward);
                    int candidateMax = candidates.Max();
                    if (candidateMax > winner)
                        winner = candidateMax;
                }
            return winner;
        }
    }
}
