using System;

class TrafficLigth
{
	private string color;

	private void ChangeColor(string newColor)
    {
        color = newColor;
    }
    public string GetColor()
    {
        return color;
    }
}
