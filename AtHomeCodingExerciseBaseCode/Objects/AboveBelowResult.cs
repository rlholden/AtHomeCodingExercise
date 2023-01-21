namespace AtHomeCodingExerciseBaseCode.Objects
{
    public class AboveBelowResult
    {
        public int Above { get; set; } = 0;
        public int Below { get; set; } = 0;
        public override string ToString()
        {
            return $"{{ \"above\": {Above}, \"below\": {Below} }}";
        }
    }
}
