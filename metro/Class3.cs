using System;
using System.Collections.Generic;
public class Station
{
    //=========== ПОЛЯ КЛАССА ==========
    // инициализируем переменную name - название станции
    public string name;

    //инициализируем переменную color - цвет станции
    public string color;

    //инициализируем переменную line - ветка, на которой станция
    public Line line;

    //инициализируем переменную isWheelchairAccessible - есть ли инвалидное кресло
    public bool isWheelchairAccessible;

    //инициализируем переменную hasParkandRide - имеется ли парк и проезд?!
    public bool hasParkandRide;

    //инициализируем переменную  hasNearbyCableCar - есть ли в близи cable car
    public bool hasNearbyCableCar;

    //инициализируем переменную transfers - список пересадок
    public List<Station> transfers;



    //======== МЕТОДЫ КЛАССА ======
    //конструктор станции без пересадок
    public Station(string name, string color)
    {
        //присваиваем перменной name даннное значение
        this.name = name;

        //присваиваем перменной color даннное значение
        this.color = color;
    }


    // конструктор для станции с пересадками
    public Station(string name, string color, List<Station> transfers)
    {

        //присваиваем перменной name даннное значение
        this.name = name;

        //присваиваем перменной color даннное значение
        this.color = color;

        //присваиваем перменной transfers даннное значение
        this.transfers = transfers;
    }


    // метод получения имени станции
    public string GetName()
    {
        // возвращаем имя станции
        return this.name;
    }


    //метод установки имени станции
    public void SetName(string name)
    {
        //присваиваем перменной name даннное значение
        this.name = name;
    }


    // метод получения информации о наличии инвалидных кресел
    public bool IsWheelchairAccessible()
    {
        //пробуем вернуть значение соответствующей перменной
        try
        {
            return isWheelchairAccessible;
        }
        //если вдруг она не инициализированна - возврат false
        catch
        {
            return false;
        }

    }

    // метод получения информации парка и проезда?!
    public bool HasParkandRide()
    {

        //пробуем вернуть значение соответствующей перменной
        try
        {

            
            return hasParkandRide;
        }
        // если вдруг она не инициализированна - возврат false
        catch
        {
            return false;
        }
    }

    // метод получения информации о наличии ближайшей cable car
    public bool HasNearbyCableCar()
    {
        // пробуем вернуть значение соответствующей перменной
        try
        {
            return hasNearbyCableCar;
        }
        // если вдруг она не инициализированна - возврат false
        catch
        {
            return false;
        }
    }

    //метод возврата имени ветки, на которой лежит станция
    public string GetLineName()
    {
        // возвращаем название ветки
        return line.name;
    }

    // метод получения списка пересадок
    public List<Station> GetTransferList()
    {

        //возврат значения перменной transfers
        return transfers;
    }

}