using System.ComponentModel;
using System.Security.Principal;

class Reference 
{
    private string book;
    private int chapter;
    private string verse;
    private string scriptureText;
    private string reference;

    public Reference(string book, int chapter, string verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
    }
    public string Stringify()
    {
        string referenceText = book + " " + chapter + ":" + verse;
        return referenceText;
    }
}