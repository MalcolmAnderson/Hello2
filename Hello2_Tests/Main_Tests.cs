namespace mba.Hello
{

    public class UnitTests
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
        public void E06_a_SumOfTheSquares_Works()
        {
            int actual = o.E06_a_SumOfTheSquares(10);
            Assert.That(actual, Is.EqualTo(385), "10 should yield 385");
        }

        [Test]
        public void E06_b_SquareOfTheSums_Works()
        {
            int actual = o.E06_b_SquareOfTheSums(10);
            Assert.That(actual, Is.EqualTo(3025), "10 should yield 3025");
        }

        [Test]
        public void E06_c_SumSuareDifference_Works()
        {
            int actual = o.E06_c_SumSuareDifference(10);
            Assert.That(actual, Is.EqualTo(2640), "10 should yield 2640");
        }


        [Test]
        public void E06_c_SumSuareDifference_Final()
        {
            int actual = o.E06_c_SumSuareDifference(100);
            Assert.That(actual, Is.EqualTo(25164150), "10 should yield 25164150");
        }

        [Test]
        public void E07_a_GetNthPrime_Works()
        {
            int actual = o.E07_a_GetNthPrime_Works(6);
            Assert.That(actual, Is.EqualTo(13), "The 6th prime should be 13");
        }

        [Test]
        public void E07_b_GetNthPrime_Works()
        {
            int actual = o.E07_a_GetNthPrime_Works(10001);
            Assert.That(actual, Is.EqualTo(104743), "The 10,001st prime should be 104743");
        }

        [Test]
        public void E08_a_GetLargestProductInSeries()
        {
            string candidate = "123456789123";
            long actual = o.E08_a_GetLargestProductInSeries(candidate, 4);
            Assert.That(actual, Is.EqualTo(3024), "Largest product should be 3024");
        }

        [Test]
        public void E08_b_GetLargestProductInSeries()
        {
            string candidate = "123456789";
            long actual = o.E08_a_GetLargestProductInSeries(candidate, 4);
            Assert.That(actual, Is.EqualTo(3024), "Largest product should be 3024");
        }

        [Test]
        public void E08_c_GetLargestProductInSeries()
        {
            string candidate = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            long actual = o.E08_a_GetLargestProductInSeries(candidate, 4);
            Assert.That(actual, Is.EqualTo(5832), "Largest product should be 5832");
        }

        [Test]
        public void E08_d_GetLargestProductInSeries()
        {
            string candidate = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            Assert.That(candidate.Length, Is.EqualTo(1000), "candidate length should be 1000");
            long actual = o.E08_a_GetLargestProductInSeries(candidate, 13);
            Assert.That(actual, Is.EqualTo(23514624000), "Largest product should be 23514624000");
        }

        [Test]
        public void E09_a_FindSpecialPythagoreanTriplet_Works()
        {
            int expected = 60; // 3 + 4 + 5 = 12 - 3 * 4 * 5 = 60
            int[] actual = o.E09_a_FindSpecialPythagoreanTriplet(12);
            Console.WriteLine($"A = {actual[1]}, B = {actual[2]}, C = {actual[3]}");
            Assert.That(actual[0], Is.EqualTo(expected), "sum of 12 = product of 60");
        }

        [Test]
        public void E09_b_FindSpecialPythagoreanTriplet_Works()
        {
            int expected = 31875000; // 3 * 4 * 5 = 60
            int[] actual = o.E09_a_FindSpecialPythagoreanTriplet(1000);
            Console.WriteLine($"A = {actual[1]}, B = {actual[2]}, C = {actual[3]}");
            Assert.That(actual[0], Is.EqualTo(expected), "to do something");
        }

        [Test]
        public void E10_a_GetAllPrimesBelow_Works()
        {
            int expected = 4; // number of primes below 8
            List<int> actual = o.E10_a_GetAllPrimesBelow(8);
            Assert.That(actual.Count, Is.EqualTo(expected), "just getting the first 4 primes");
        }

        [Test]
        public void E10_c_GetSumOfIntList_Works()
        {
            long expected = 17; // sum of the primes below 8
            List<int> primes = o.E10_a_GetAllPrimesBelow(8);
            long actual = o.E10_b_GetSumOfIntList(primes);
            Assert.That(actual, Is.EqualTo(expected), "just getting the first 4 primes");
        }

        [Test]
        public void E11_a_ReadStringAsGrid_Works()
        {
            int[,] expected = { { 08, 02, 97 }, { 22, 3, 4 } };
            int rows = 2;
            int columns = 3;
            //  8  2 97
            // 22  3  4
            string myString = "08 02 97 22 03 04";
            int[,] actual = o.E11_a_ConvertStringToIntGrid(myString, rows, columns);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void E11_b_FindLargestProduct_Horizontal_Works()
        {
            int rows = 2;
            int columns = 3;
            //  8  2 97
            // 22  3  4
            string myString = "08 02 97 22 03 04";
            int[,] grid = o.E11_a_ConvertStringToIntGrid(myString, rows, columns);
            Assert.That(2, Is.EqualTo(grid.GetLength(0)), "get rows");
            Assert.That(3, Is.EqualTo(grid.GetLength(1)), "get columns");
            int actual = o.E11_b_GetLargestHorizontalProductFromGrid(grid);
            int expected = 194;
            //expected = 7;
            Assert.That(actual, Is.EqualTo(expected), "should find 2*97");
        }

        [Test]
        public void E11_c_FindLargestProduct_Verticle_Works()
        {
            int rows = 2;
            int columns = 3;
            //  8  2 97
            // 22  3  4
            string myString = "08 02 97 22 03 04";
            int[,] grid = o.E11_a_ConvertStringToIntGrid(myString, rows, columns);
            int actual = o.E11_c_GetLargestVerticleProductFromGrid(grid);
            int expected = 388;
            Assert.That(actual, Is.EqualTo(expected), "should find 4*97");
        }

        [Test]
        public void E11_d_FindLargestProduct_Diagonal_Works()
        {
            int rows = 2;
            int columns = 3;
            //  8  2 97
            // 22  3  4
            string myString = "08 02 97 22 03 04";
            int[,] grid = o.E11_a_ConvertStringToIntGrid(myString, rows, columns);
            int actual = o.E11_d_GetLargestDiagonalProductFromGrid(grid);
            int expected = 291;
            Assert.That(actual, Is.EqualTo(expected), "should find 3*97");
        }

        [Test]
        public void E11_e_FindLargestProduct_2_Works()
        {
            int rows = 2;
            int columns = 3;
            //  8  2 97
            // 22  3  4
            string myString = "08 02 97 22 03 04";
            int[,] grid = o.E11_a_ConvertStringToIntGrid(myString, rows, columns);
            int actual = o.E11_e_GetLargestProductFromGrid_Len2(grid, 2);
            int expected = 388;
            Assert.That(actual, Is.EqualTo(expected), "should find 4*97");
        }

        [Test]
        public void E11_e_FindLargestProduct_3_Works()
        {
            int rows = 2;
            int columns = 3;
            //  8  2 97
            // 22  3  4
            string myString = "08 02 97 22 03 04";
            int[,] grid = o.E11_a_ConvertStringToIntGrid(myString, rows, columns);
            int actual = o.E11_e_GetLargestProductFromGrid_Len2(grid, 3);
            int expected = 1552;
            Assert.That(actual, Is.EqualTo(expected), "should find 8*2*97");
        }

        [Test]
        public void E11_f_FindLargestProduct_All_Works()
        {
            int rows = 4;
            int columns = 4;
            //  8  2 97 14
            // 22  3  4 12
            // 07 15 23 19
            // 72 05 11 21
            string myString = "08 02 97 14 22 03 04 12 07 15 23 19 72 05 11 21";
            int[,] grid = o.E11_a_ConvertStringToIntGrid(myString, rows, columns);
            int actual = o.E11_e_GetLargestProductFromGrid_Len2(grid, 2);
            int expected = 1358;
            Assert.That(actual, Is.EqualTo(expected), "should find 14*97");
        }


        [Test]
        public void E11_g_FindLargestProduct_20x20_Works()
        {
            string myString = "08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08 49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00 81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65 52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91 22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80 24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50 32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70 67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21 24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72 21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95 78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92 16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57 86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58 19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40 04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66 88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69 04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36 20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16 20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54 01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48";
            int rows = 20;
            int columns = 20;
            int[,] grid = o.E11_a_ConvertStringToIntGrid(myString, rows, columns);
            int actual = o.E11_e_GetLargestProductFromGrid_Len2(grid, 4);
            int expected = 70600674;
            Assert.That(actual, Is.EqualTo(expected), "should find 70600674");

        }


        [Test]
        public void SEL_01_findintarget_Works()
        {
            bool expected = true;
            bool actual = o.SEL_01_findintarget("adabc", "ab");
            Assert.That(actual, Is.EqualTo(expected), "expected true");
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
            Console.WriteLine($"primes length = {primes.Count} and the last prime is {primes[primes.Count - 1]}");
            int[] other_primes = { 2, 3, 5, 7, 11 };
            primes2 = new List<int>(other_primes);
            Assert.AreEqual(primes, primes2);
            primes2 = o.GetPrimesLessThanCandidate(primes, 3);
            primes2 = o.GetPrimesLessThanCandidate(primes, 32);
            int expected = 31;
            int actual = primes2[primes2.Count - 1];
            Console.WriteLine($"primes2 length = {primes2.Count} and the last prime is {primes2[primes2.Count - 1]}");
            Assert.That(actual, Is.EqualTo(expected));
        }


    }

    public class IntegrationTests
    {
        Main o;
        [SetUp]
        public void Setup()
        {
            o = new Main();
        }

        [Test]
        public void E04_d_Largest_Palindrome_Product()
        {
            long actual = o.E04_GetLargestPalindromeByDigitCount(4);
            Assert.That(actual, Is.EqualTo(99000099), "failure of 4 digit control ");
        }

        [Test]
        public void E05_c_Smallest_Multiple()
        {
            long actual = o.E05_GetSmallestMultiple(20);
            Assert.That(actual, Is.EqualTo(232792560), "20 should yield 232792560");
        }

        [Test]
        public void E10_b_GetAllPrimesBelow_Works()
        {
            int expected = 148933; // number of primes below 2,000,000
            List<int> actual = o.E10_a_GetAllPrimesBelow(2000000);
            Assert.That(actual.Count, Is.EqualTo(expected), "just getting the first 4 primes");
        }

        [Test]
        public void E10_d_GetSumOfIntList_Works()
        {
            long expected = 142913828922; // sum of the primes below 2000000
            List<int> primes = o.E10_a_GetAllPrimesBelow(2000000);
            long actual = o.E10_b_GetSumOfIntList(primes);
            Assert.That(actual, Is.EqualTo(expected), "just getting the first 4 primes");
        }


    }
}