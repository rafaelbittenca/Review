using System;

namespace AlgortGeneral
{
	public static class ReverseString
    {
        public static string ReverseArray(string text)
        {
            if (text == null) return null;

            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }

        public static string ReverseText(string text)
        {
            if (text == null) return null;
            char[] textArray = text.ToCharArray();
            int len = text.Length - 1;

            for (int i = 0; i < len; i++, len--)
            {
                textArray[i] ^= textArray[len];
                textArray[len] ^= textArray[i];
                textArray[i] ^= textArray[len];
            }
            return new string(textArray);
        }
    }
}
