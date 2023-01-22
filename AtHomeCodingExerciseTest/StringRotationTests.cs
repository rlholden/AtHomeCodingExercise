using AtHomeCodingExerciseBaseCode;
using NUnit.Framework;

namespace AtHomeCodingExerciseTest
{
    public class StringRotationTests
    {
        [Test]
        [TestCase("MyString", 0, ExpectedResult = "MyString")]
        [TestCase("MyString", 1, ExpectedResult = "gMyStrin")]
        [TestCase("MyString", 2, ExpectedResult = "ngMyStri")]
        [TestCase("MyString", 3, ExpectedResult = "ingMyStr")]
        [TestCase("MyString", 4, ExpectedResult = "ringMySt")]
        [TestCase("MyString", 5, ExpectedResult = "tringMyS")]
        [TestCase("MyString", 6, ExpectedResult = "StringMy")]
        [TestCase("MyString", 7, ExpectedResult = "yStringM")]
        [TestCase("MyString", 8, ExpectedResult = "MyString")]
        public string StringRotation_Success(string originalString, int rotationAmount)
        {
            return AtHomeCodingExercise.stringRotation(originalString, rotationAmount);
        }
        [Test]
        [TestCase("MyString", -15)]
        [TestCase("MyString", 9)]
        public void StringRotation_ArgumentException(string originalString, int rotationAmount)
        {
            Assert.Throws<System.ArgumentException>(() => AtHomeCodingExercise.stringRotation(originalString, rotationAmount));
        }
        [Test]
        [TestCase("", -15)]
        [TestCase(null, 9)]
        [TestCase(" ", 9)]
        public void StringRotation_NullArgumentException(string originalString, int rotationAmount)
        {
            Assert.Throws<System.ArgumentNullException>(() => AtHomeCodingExercise.stringRotation(originalString, rotationAmount));
        }
    }
}