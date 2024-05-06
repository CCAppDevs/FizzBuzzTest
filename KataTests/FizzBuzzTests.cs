using FBTest;

namespace KataTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        [DataRow(1,"1")]
        [DataRow(2,"2")]
        public void FizzBuzz_Should_Return_String(int x, string expected)
        {
            // arrange
            string result = "";

            // act
            result = Library.FizzBuzz(x);

            // assert
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        public void FizzBuzz_Should_Return_ANumericReprestationOfTheInputAsAString(int x, string expected)
        {
            // arrange
            string result = "";

            // act
            result = Library.FizzBuzz(x);

            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(3, "Fizz")]
        [DataRow(6, "Fizz")]
        [DataRow(12, "Fizz")]
        public void FizzBuzzShouldReturnFizz_WhenInputIsMultipleOf3(int x, string expected)
        {
            string result = "";

            result = Library.FizzBuzz(x);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(5, "Buzz")]
        [DataRow(10, "Buzz")]
        //[DataRow(15, "Buzz")]
        public void FizzBuzzShouldReturnBuzz_WhenInputIsMulipleOf5(int x, string expected)
        {
            string result = "";

            result = Library.FizzBuzz(x);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(15, "FizzBuzz")]
        [DataRow(30, "FizzBuzz")]
        public void FizzBuzzShouldReturnBuzz_WhenInputIsMulipleOf3And5(int x, string expected)
        {
            string result = "";

            result = Library.FizzBuzz(x);

            Assert.AreEqual(expected, result);
        }
    }
}