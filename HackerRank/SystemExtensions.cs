namespace System
{
    public static class SystemExtensions
    {
        public static float Truncate(this float number, int digits)
        {
            var times = Math.Pow(10, digits);
            return (float)(Math.Truncate(number * times) / times);
        }

        public static bool IsPalindrome(this string text) 
        {
            for (var i = 0; i < text.Length; i++) 
            {
                var j = text.Length - i - 1;
                if (i != j && text[i] != text[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
