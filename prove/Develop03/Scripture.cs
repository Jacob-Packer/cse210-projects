class Scripture
{
    private string reference;
    private string scriptureText;
    private List<Word> words = new List<Word>();

    public Scripture(Reference reference, string scriptureText)
    {
        this.reference = reference.Stringify();
        this.scriptureText = scriptureText; 

        // Split the input string by spaces
        string[] splitScriptureText = scriptureText.Split(' ');
        foreach (string text in splitScriptureText)
        {
            Word word = new Word(text);
            words.Add(word);
        }

        // Word word = new Word(); 
        // split scriptureText by " "
        // add each word to words list
        // foreach word in words
        // send each word to Word(word)
        // 
        // foreach word 
        // add word to list<word>
        // scripture

    }
    public string DisplayScripture(){
        string scriptureText = "";
        foreach (Word word in words)
        {
            scriptureText += word.DisplayWord(word.IsHidden());
        }
        return scriptureText;
    }
}