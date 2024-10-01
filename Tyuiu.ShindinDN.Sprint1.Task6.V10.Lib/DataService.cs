using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShindinDN.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string[] words = value.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word.Length > 1 && word.Length % 2 != 0)
                {
                    word = word.Remove(word.Length / 2, 1);
                }
                words[i] = word;
            }
            return string.Join(" ", words);

        }
    }
}
