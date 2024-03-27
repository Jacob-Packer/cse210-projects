using System.ComponentModel;
using System.Diagnostics;

class Word
{
    private bool hidden;
    private string word;
    public Word(string word, bool hidden=false)
    {
        this.word = word;
        this.hidden = hidden;
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public string DisplayWord(bool hidden)
    {
        if (!hidden)
        {
            return word;
        }
        else 
        {
            string wordText = "";
            foreach (char letter in word)
            {
                wordText += "_";
            }
            return wordText;
        }
    }
}