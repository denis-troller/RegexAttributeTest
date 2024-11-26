namespace TestProject1
{
    internal static partial class StringExtensions
    {
        public static string RemoveWhitespaces(this string s)
        {
            return WhitespaceRegex().Replace(s, string.Empty);
        }

        [GeneratedRegex(@"\s")]
        private static partial Regex WhitespaceRegex();
    }

}
