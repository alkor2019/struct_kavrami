using System;

class Program {
  public static void Main (string[] args) {
    Rectangle rectangle = new Rectangle();
    rectangle.ShortEdge = 3;
    rectangle.LongEdge =  4;

    Console.WriteLine("Class alan hesabı : {0}", rectangle.CalculateArea());

    //RectangleStruct rectangleStruct = new RectangleStruct(3,4); 
    RectangleStruct rectangleStruct;
    rectangleStruct.ShortEdge = 3;
    rectangleStruct.LongEdge = 4;

    Console.WriteLine("Struct alan hesabı : {0}", rectangleStruct.CalculateArea());
  }
}

class Rectangle
{
  public int ShortEdge;

  public int LongEdge;

  public Rectangle()
  {
    ShortEdge =3;
    LongEdge =4;
  }

  public long CalculateArea()
  {
    return this.ShortEdge*this.LongEdge;
  }
}

struct RectangleStruct
{
  public int ShortEdge;

  public int LongEdge;

  //Constructor parametresiz çalışmaz
  public RectangleStruct(int shortEdge,int longEdge)
  {
    ShortEdge =shortEdge;
    LongEdge =longEdge;
  }

  public long CalculateArea()
  {
    return this.ShortEdge*this.LongEdge;
  }
}