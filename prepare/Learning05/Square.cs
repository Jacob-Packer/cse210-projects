using System.Formats.Tar;

class Square : Shape
{
    private double side = 1;
    public Square(string color, double side) : base(color)
    {
        this.side = side;
    }
    public override double GetArea()
    {
        return side * side;
    }
}
/*
<o)
(_>

>o) 
(_> 

(o>
<_}----

(o<
<_)-|----

 ^
(O)  <( )  ( )  ( )>
            v

   /\  (o<  >o)  \/

  _______
 / |   | \
|  |(o<|  |
|  |<_)|  |
|__|___|__|
   JACOB


*/