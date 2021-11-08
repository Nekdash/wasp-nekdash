using System;
using System.Collections.Generic;

public class Metro
{
    public List<Line> lines;
    public string city;
    public Metro(string city_in)
    {
        lines = new List<Line>();
        city = city_in;
    }
    public string GetCity()
    {
        return city;
    }
    public void AddLine(string name, string color)
    {
        lines.Add(new Line(name, color));

    }
    public void RemoveLine(string name)
    {
        for (int i = 0; i < lines.Count; i++)
        {
            if (lines[i].name == name)
            {
                lines.RemoveAt(i);
            }
        }
    }

}