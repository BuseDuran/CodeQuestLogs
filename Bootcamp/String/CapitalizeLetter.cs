namespace CodeQuest.Bootcamp.String
{
    public class CapitalizeLetter
    {
        public static string StringChallenge(string str)
        {
            string[] words = str.Split(' ');
            for (int i = 0 ; i < words.Length ; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }

            return string.Join(" ", words);

            //split the string into array of words
            //for each word, capitalize the first letter and append the rest of the word
            //join the array of words into a string

            //input: "hello world"
            //output: "Hello World"
        }
    }
}
