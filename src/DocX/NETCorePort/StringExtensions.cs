namespace DocX.NETCorePort
{
    public static class StringExtensions
    {
        public static bool HasValue(this string val)
        {
            return !string.IsNullOrEmpty(val);
        }
    }
}
