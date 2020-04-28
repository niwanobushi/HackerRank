namespace System
{
    public static class SystemExtensions
    {
        public static float Truncate(this float number, int digits)
        {
            var times = Math.Pow(10, digits);
            return (float)(Math.Truncate(number * times) / times);
        }
    }
}
