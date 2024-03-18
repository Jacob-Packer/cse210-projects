using System.Security.Cryptography.X509Certificates;

abstract public class Shape
{
    private string color = "red";
    public Shape(){}
    public string GetColor()
    {
        return color;
    }
    public virtual void SetColor(string color)
    {
        this.color = color;
    }

    public abstract double GetArea();
    
}