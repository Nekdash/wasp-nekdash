using System;
using System.Collections.Generic;

public class Metro
{
    // ====== ПОЛЯ КЛАССА =======
    // список линий метро
    public List<Line> lines;

    //название города
    public string city;


    //======== МЕТОДЫ КЛАССА =======
    // конструктор с параметрами
    //city - название города
    public Metro(string city_in)
    {
        // присваиваем переменной lines пустой список линий метро
        lines = new List<Line>();

        // присваиваем city введенное значение названия города
        city = city_in;
    }

    // метод получения города
    public string GetCity()
    {
        // Галя, у нас возврат переменной city
        return city;
    }

    // метод добавления новой ветки метро
    public void AddLine(string name, string color)
    {
        //добавляем к списку линий новую с заданными name и color
        lines.Add(new Line(name, color));

    }

    // метод удаления линии
    public void RemoveLine(string name)
    {
        // перебираем весь вписок линий
        for (int i = 0; i < lines.Count; i++)
        {
            // когда мы нашли нужную линию
            if (lines[i].name == name)
            {
                // удалаяем линию из списка линий метро
                lines.RemoveAt(i);
            }
        }
    }

    // метод нахождения станции без линии
    public Station FindStation(string name)
    {
        // перебираем все ветки
        foreach(Line line in lines)
        {
            // если на этой ветке есть нужная станция
            if (line.FindStationByName(name) != null)
            {
                // возвращаем нужную станцию
                return line.FindStationByName(name);
            }
        }
        return null;
    }

    // метод поиска станции во всем метро зная линию
    public Station FindStation(string name, string lineName)
    {
        // перебираем все линии
        foreach(Line line in lines)
        {
            // если имя линии совпадает с тем что нам нужно
            if ( line.name == lineName)
            {
                // вернуть станцию через йункцию линии
                return line.FindStationByName(name);
            }
        }
        //если такой нет - вернуть ничто
        return null;
    }
    

}