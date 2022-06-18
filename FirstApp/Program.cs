using System;

class Pen
{
    public string Color;
    public int Cost;

    public Pen()
    {
        Color = "Чёрный";
        Cost = 100;
    }
    public Pen(string penColor,int penCost)
    {
        Color = penColor;
        Cost = penCost;
    }
}