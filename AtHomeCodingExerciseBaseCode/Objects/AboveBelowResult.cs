namespace AtHomeCodingExerciseBaseCode.Objects
{
    /// <summary>
    /// Object to return for exercise.
    /// </summary>
    public class AboveBelowResult
    {
        /// <summary>
        /// The count of integers whose values are above the comparison value.
        /// </summary>
        public int Above { get; set; } = 0;

        /// <summary>
        /// The number of integers whose values are below the comparison value.
        /// </summary>
        public int Below { get; set; } = 0;

        /// <summary>
        /// Override of string rendering for display purposes.
        /// </summary>
        /// <returns>Readable format of the integer counts.</returns>
        public override string ToString()
        {
            return $"{{ \"above\": {Above}, \"below\": {Below} }}";
        }
    }
}
