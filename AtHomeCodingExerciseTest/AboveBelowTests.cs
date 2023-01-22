using AtHomeCodingExerciseBaseCode;
using NUnit.Framework;
using System.Collections.Generic;

namespace AtHomeCodingExerciseTest
{
    public class AboveBelowTests
    {
        [Test]
        [TestCase(arg1: new int[] { 1, 5, 2, 1, 10, }, arg2: -15, ExpectedResult = "{ \"above\": 5, \"below\": 0 }")]
        [TestCase(arg1: new int[] { 1, 5, 2, 1, 10, }, arg2: 0, ExpectedResult = "{ \"above\": 5, \"below\": 0 }")]
        [TestCase(arg1: new int[] { 1, 5, 2, 1, 10, }, arg2: 3, ExpectedResult = "{ \"above\": 2, \"below\": 3 }")]
        [TestCase(arg1: new int[] { 1, 5, 2, 1, 10, }, arg2: 6, ExpectedResult = "{ \"above\": 1, \"below\": 4 }")]
        [TestCase(arg1: new int[] { 1, 5, 2, 1, 10, }, arg2: 22, ExpectedResult = "{ \"above\": 0, \"below\": 5 }")]
        public string AboveBelow_Success(IEnumerable<int> list, int comparisonValue)
        {
            return AtHomeCodingExercise.aboveBelow(list, comparisonValue).ToString();
        }
        [Test]
        [TestCase(arg1: null, arg2: -15)]
        public void AboveBelow_Failure(IEnumerable<int> list, int comparisonValue)
        {
            Assert.Throws<System.ArgumentNullException>(() => AtHomeCodingExercise.aboveBelow(list, comparisonValue));
        }
    }
}