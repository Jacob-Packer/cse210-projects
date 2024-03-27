using System.Diagnostics;

class Scripture
{
    private string reference;
    private string scriptureText;
    private double difficultyLevel;
    private List<Word> words = new List<Word>();

    public Scripture(Reference reference, string scriptureText, double difficultyLevel)
    {
        this.reference = reference.Stringify();
        this.scriptureText = scriptureText; 
        this.difficultyLevel = difficultyLevel;

        double wordIndex = 1;
        // Split the input string by spaces
        string[] splitScriptureText = scriptureText.Split(' ');
        foreach (string text in splitScriptureText)
        {
            double chance = wordIndex % difficultyLevel;
            if (chance == 0)
            {
                bool hidden = false;
                Word word = new Word(text,hidden);
                words.Add(word);
            }
            else
            {
                bool hidden = true;
                Word word = new Word(text,hidden);
                words.Add(word);
            }
            wordIndex++;
        }
    }
    
    public string GetScripture(){
        string scriptureText = "";
        foreach (Word word in words)
        {
            scriptureText += $"{word.DisplayWord(word.IsHidden())} ";
        }
        return scriptureText;
    }
}