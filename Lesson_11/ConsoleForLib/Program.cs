using System.Text;
using LibraryTask;
namespace ConsoleForLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string sampleText = "У своїй сумі прислів’я та приказки становлять начебто звід правил, якими людина має керуватися у повсякденному житті.";

            int vowelsCount = UkrainianStringUtils.CountVowels(sampleText);
            int consonantsCount = UkrainianStringUtils.CountConsonants(sampleText);
            string reversedText = UkrainianStringUtils.ReverseString(sampleText);
            string textWithoutDuplicates = UkrainianStringUtils.RemoveDuplicates(sampleText);
            string textWithoutPunctuation = UkrainianStringUtils.RemovePunctuation(sampleText);

            Console.WriteLine("Оригінальний текст: " + sampleText);
            Console.WriteLine("Кількість голосних: " + vowelsCount);
            Console.WriteLine("Кількість приголосних: " + consonantsCount);
            Console.WriteLine("Реверсований текст: " + reversedText);
            Console.WriteLine("Текст без дублікатів: " + textWithoutDuplicates);
            Console.WriteLine("Текст без пунктуації: " + textWithoutPunctuation);
        }
    }
}