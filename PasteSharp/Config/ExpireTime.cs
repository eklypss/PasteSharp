namespace PasteSharp.Config
{
    /// <summary>
    /// Constant values which determine the expire date of the paste. Pastebin only supports these 9
    /// constant values, custom durations aren't supported.
    /// </summary>
    public static class ExpireTime
    {
        public const string Never = "N";
        public const string TenMinutes = "10M";
        public const string OneHour = "1H";
        public const string OneDay = "1D";
        public const string OneWeek = "1W";
        public const string TwoWeeks = "2W";
        public const string OneMonth = "1M";
        public const string SixMonths = "6M";
        public const string OneYear = "1Y";
    }
}