public class MaximumNumberofWordsFoundinSentences
{
    public int MostWordsFound(string[] sentences)
    {
        int[] wordsNum = new int[sentences.Length];
        for (int i = 0; i < sentences.Length; i++)
        {
            string[] words = { };
            words = sentences[i].Split(' ');
            wordsNum[i] = words.Length; 
        }
        return wordsNum.Max();
    }
}