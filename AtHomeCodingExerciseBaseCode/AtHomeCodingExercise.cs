using AtHomeCodingExerciseBaseCode.Objects;

namespace AtHomeCodingExerciseBaseCode
{
    public static class AtHomeCodingExercise
    {
        /// <summary>
        /// Determines the count of integers in a list that are have a value above or below a comparison value.
        /// </summary>
        /// <param name="list">A list of integers.</param>
        /// <param name="comparisonValue">Value used for comparison against the <paramref name="list"/>.</param>
        /// <returns><see cref="AboveBelowResult"/> object containing the count of integers in the <paramref name="list"/> above or below the <paramref name="comparisonValue"/>.</returns>
        public static AboveBelowResult aboveBelow(IEnumerable<int> list, int comparisonValue)
        {
            return new()
            {
                Above = list.Where(x => x > comparisonValue).Count(),
                Below = list.Where(x => x < comparisonValue).Count()
            };
        }

        /// <summary>
        /// Generates a string by rotating the letters of the <paramref name="originalString"/> at the end of the string to the front
        /// and shifting the string accordingly. The number of letters to rotate is specified using <paramref name="rotationAmount"/>.
        /// </summary>
        /// <param name="originalString">The string whose letters should be rotated.</param>
        /// <param name="rotationAmount">The number of characters of the string to rotate.</param>
        /// <returns>A version of the <paramref name="originalString"/>, with <paramref name="rotationAmount"/> letters rotated.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static string stringRotation(string originalString, int rotationAmount)
        {
            if (rotationAmount < 0)
            {
                throw new ArgumentException($"Rotation amount ({rotationAmount}) must be positive");
            }
            if (rotationAmount > originalString.Length)
            {
                throw new ArgumentException($"Rotation amount ({rotationAmount}) must be less than or equal to the string length ({originalString.Length})");
            }
            int amountToRotate = originalString.Length - rotationAmount;
            return originalString[amountToRotate..] + originalString[..amountToRotate];
        }
    }
}
