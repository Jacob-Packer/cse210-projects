using System.Security.Cryptography.X509Certificates;

abstract public class Shape
{
    private string color;
    public Shape(string color)
    {
        this.color = color;
    }
    public string GetColor()
    {
        return color;
    }
    public virtual void SetColor(string color)
    {
        this.color = color;
    }

    public virtual void GetArea(){}
    
}