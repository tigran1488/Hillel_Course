using System.Text.RegularExpressions;

namespace LibraryTask
{
   
        public static class UkrainianStringUtils
        {
            public static int CountVowels(string input)
            {
                char[] vowels = { 'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я' };
                input = input.ToLower();
                int count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (vowels.Contains(input[i]))
                    {
                        count++;
                    }
                }
                return count;
            }
            public static int CountConsonants(string input)
            {
                char[] consonants = { 'б', 'в', 'г', 'ґ', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
                input = input.ToLower();
                int count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (consonants.Contains(input[i]))
                    {
                        count++;
                    }
                }
                return count;
            }
            public static string ReverseString(string input)
            {
                return new string(input.Reverse().ToArray());
            }
            public static string RemoveDuplicates(string input)
            {
                string result = string.Empty;
                foreach (char c in input)
                {
                    if (result.IndexOf(c) == -1)
                    {
                        result += c;
                    }
                }
                return result;
            }

            public static string RemovePunctuation(string input)
            {
                return Regex.Replace(input, @"\p{P}", "");
            }
        }

    }
