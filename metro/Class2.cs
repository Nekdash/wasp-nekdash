using System;
using System.Collections.Generic;

public class Line
{
    // ====== ПОЛЯ КЛАССА ====== 
    //инициализируем переменную список станций
    public List<Station> stations;

    // инициализируем переменную name - название ветки
    public string name;

    //инициализируем перменную color - цвет ветки
    public string color;


    //======= МЕТОДЫ КЛАССА ===========
    //контсруктор линии с переменными name и color
    public Line(string name, string color)
    {
        //присваиваем переменной name значение name
        this.name = name;
        //присваиваем переменной color значение color
        this.color = color;
    }

    // метод поиска станции видимо
    public Station GetStation(string station)
    {
        // перебираем список станций
        for (int i = 0; i < stations.Count; i++)
        {
            // если имя совпало
            if (stations[i].name == station)
            {
                // возвращаем станцию
                return stations[i];
            }
        }
        // если такой нет - вернуть ничего
        return null;

    }


    // метод получения имени ветки
    public string GetName()
    {
        // возвращаем значение перменной name
        return name;
    }

    // метод установки имени ветки
    public void SetName(string name)
    {
        // присваимваем переменной name данное значение
        this.name = name;
    }




    // метод возвращения цвета ветки
    public string GetColor()
    {
        // возвращаем значение переменной color
        return color;
    }

    // метод изменения / установки цвета ветки
    public void SetColor(string color)
    {
        // присваиваем переменной color данное значение
        this.color = color;
    }


    // метод добавления станции на линию зная пересадки
    public void AddStation(string name, string color, List<Station> transfers)
    {
        // добавлем новый объект станции с данными name, color и transfers
        stations.Add(new Station(name, color, transfers));
    }



    // метод добавления станции на линию
    public void AddStation(string name, string color)
    {
        // добавлем новый объект станции с аднными name и color
        stations.Add(new Station(name, color));
    }


    // метод удаления станции
    public void RemoveStation(string name)
    {
        //перебираем список станций
        for (int i = 0; i < stations.Count; i++)
        {
            //когда станции совпадают по имени
            if (stations[i].name == name)
            {
                // удаляем станцию из списка
                stations.RemoveAt(i);
            }
        }

    }

    //метод поиска станции по имени
    public Station FindStationByName(string name)
    {
        //перебираем весь список станций
        for (int i = 0; i < stations.Count; i++)
        {
            // когда станция совпадает с искомым именем
            if (stations[i].name == name)
            {
                // возвращем эту станцию
                return stations[i];
            }
        }
        // если не нашли вернуть ничего
        return null;
    }



    //метод получения списка станций
    public List<Station> GetStationList(string name)
    {
        //зачем название мне не ясно так что пусть будет
        Station temp = FindStationByName(name);

        // возвращаем список станций 
        return stations;
    }
}