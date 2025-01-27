namespace mba.Hello
{
    
    public class Tests
    {
        Main o;
        [SetUp]
        public void Setup()
        {
            o = new Main();

        }

        [Test]
        public void Instantiate()
        {
            bool expected = false;
            bool isPositive = o.IsPositive(-1);
            //Assert.AreEqual(expected, isPositive, "-1 should not be positive");
            Assert.That(isPositive, Is.EqualTo(expected), "-1 should not be positive");
        }

        [Test]
        public void E01_a_Multiples_of_3_or_5_test()
        {
            Assert.IsTrue(true);
            int actual = o.E1_Multiples_of_3_or_5(10);
            int expected = 23;
            Assert.That(actual, Is.EqualTo(expected), "unexpected result");
        }

        [Test]
        public void E01_b_Multiples_of_3_or_5_test()
        {
            Assert.IsTrue(true);
            int actual = o.E1_Multiples_of_3_or_5(1000);
            int expected = 233168;
            Assert.That(actual, Is.EqualTo(expected), "unexpected result");
        }

        [Test]
        public void E02_a_Even_Fibonacci_Numbers()
        {
            int actual = o.E2_Even_Fibonacci_Numbers(90);
            int expected = 44;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void E02_b_Even_Fibonacci_Numbers()
        {
            int actual = o.E2_Even_Fibonacci_Numbers(4000001);
            int expected = 4613732;
            Assert.That(actual, Is.EqualTo(expected));
        }



        [Test]
        public void E03_a_Largest_Prime_Factor()
        {
            long actual = o.E3_Largest_Prime_Factor(6);
            long expected = 3;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void E03_b_Largest_Prime_Factor()
        {
            long actual = o.E3_Largest_Prime_Factor(13195);
            long expected = 29;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void E03_c_Largest_Prime_Factor()
        {
            long actual = o.E3_Largest_Prime_Factor(600851475143);
            long expected = 6857;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void E04_a_Largest_Palindrome_Product()
        {
            Assert.That(o.IsPalindrome(6), Is.EqualTo(true), "6");
            Assert.That(o.IsPalindrome(66), Is.EqualTo(true), "66");
            Assert.That(o.IsPalindrome(67), Is.EqualTo(false), "67");
            Assert.That(o.IsPalindrome(101), Is.EqualTo(true), "101");
            Assert.That(o.IsPalindrome(232), Is.EqualTo(true), "232");
            Assert.That(o.IsPalindrome(424), Is.EqualTo(true), "424");
            Assert.That(o.IsPalindrome(12321), Is.EqualTo(true), "12321");
            Assert.That(o.IsPalindrome(12345654321), Is.EqualTo(true), "12345654321");
        }


        [Test]
        public void E04_b_Largest_Palindrome_Product()
        {
            long actual = o.E04_GetLargestPalindromeByDigitCount(2);
            Assert.That(actual, Is.EqualTo(9009), "failur of 3 digit control ");

        }

        [Test]
        public void E04_c_Largest_Palindrome_Product()
        {
            long actual = o.E04_GetLargestPalindromeByDigitCount(3);
            Assert.That(actual, Is.EqualTo(906609), "failure of 3 digit control ");

        }

        [Test]
        public void E04_d_Largest_Palindrome_Product()
        {
            long actual = o.E04_GetLargestPalindromeByDigitCount(4);
            Assert.That(actual, Is.EqualTo(99000099), "failure of 4 digit control ");

        }

        [Test]
        public void E05_a_Smallest_Multiple()
        {
            long actual = o.E05_GetSmallestMultiple(4);
            Assert.That(actual, Is.EqualTo(12), "4 should yield 12");
        }

        [Test]
        public void E05_b_Smallest_Multiple()
        {
            long actual = o.E05_GetSmallestMultiple(10);
            Assert.That(actual, Is.EqualTo(2520), "10 should yield 2520");
        }

        [Test]
        public void E05_c_Smallest_Multiple()
        {
            long actual = o.E05_GetSmallestMultiple(20);
            Assert.That(actual, Is.EqualTo(232792560), "20 should yield 232792560");
        }



        [Test]
        public void E99_is_prime_works()
        {
            List<int> primes = new List<int>();
            List<int> primes2 = new List<int>();
            primes.Add(2);
            primes.Add(3);
            primes.Add(5);
            primes.Add(7);  
            primes.Add(11);
            Console.WriteLine($"primes length = {primes.Count} and the last prime is {primes[primes.Count-1]}");
            int[] other_primes = { 2, 3, 5, 7, 11 };
            primes2 = new List<int>(other_primes);
            Assert.AreEqual(primes, primes2);
            primes2 = o.GetPrimesLessThanCandidate(primes, 3);
            primes2 = o.GetPrimesLessThanCandidate(primes, 32);
            int expected = 31;
            int actual = primes2[primes2.Count-1];
            Console.WriteLine($"primes2 length = {primes2.Count} and the last prime is {primes2[primes2.Count - 1]}");
            Assert.That(actual, Is.EqualTo(expected));


        }


    }
}