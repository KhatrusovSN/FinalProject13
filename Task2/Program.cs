namespace Task2
{
    internal class Program
    {
        static string path = "C:\\Users\\Sergey\\Downloads\\Text1.txt";
        static void Main(string[] args)
        {
            string text = File.ReadAllText(path);
            string? noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            char[] charsDel = new char[] { ' ', '\n' };

            string[]? words = noPunctuationText.Split(charsDel, StringSplitOptions.RemoveEmptyEntries);
            var repeatedWords = new Dictionary<string, int>();

            foreach ( var word in words )
            {
                bool cont = repeatedWords.ContainsKey(word);
                int count;

                if (cont)
                {
                    repeatedWords.TryGetValue(word, out count);
                    repeatedWords.Remove(word);
                    repeatedWords.Add(word, count + 1);
                }
                else
                {
                    repeatedWords.Add(word, 1);
                }
            }

            int i = 0;
            foreach (var word in repeatedWords.OrderByDescending(key => key.Value))
            {
                if (i < 10)
                {
                    Console.WriteLine($"Word: {word.Key} \t Repeats: {word.Value}");
                    i++;
                }
            }
        }
    }
}