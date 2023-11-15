using Library;
namespace PrimeFactors_UnitTest
{
    public class UnitTest
    {
        [Fact]
        public void TestPrimeFactors20()
        {
            int number = 20;
            string expected = "5 * 2 * 2";

            string actual = NumberFactors.PrimeFactors(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactors293()
        {
            int number = 293;
            string expected = "293";           

            string actual = NumberFactors.PrimeFactors(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactors87()
        {
            int number = 87;
            string expected = "29 * 3";

            string actual = NumberFactors.PrimeFactors(number);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void TestPrimeFactors169()
        {
            int number = 169;
            string expected = "13 * 13";

            string actual = NumberFactors.PrimeFactors(number);

            Assert.Equal(expected, actual);
        }
    }
}