using System;
using System.Collections.Generic;

namespace metro
{
    public class Car
    {
        // класс это образец, шаблон переменных
        public int numberOfWheels;
        public double size;
        public int numberOfDoors;
        public string color;
        public bool roof;
        public string model;
        public int year;

        //чтоб не вбивать все переменные
        //самим на каждой строчке 
        //мы пишем конструктор


        public void PrintCar()
        {
            Console.WriteLine(numberOfWheels);
        }
        public Car(string model_in, int year_in, bool roof_in, int numberOfWheels_in)
        {
            model = model_in;
            year = year_in;
            roof = roof_in;
            numberOfWheels = numberOfWheels_in;
        }
    }
    public class Metro
    {
        public List<Line> lines;
        public string city;
        public Metro( string city_in){
            lines = new List<Line>();
            city = city_in;
         }
        public string GetCity()
        {
            return city;
        }
        public AddLine(string name, string color)
        {
            lines.Add(Line())
        }
    }
    public class Line
    {
        public List<Station> stations;
        public string name;
        public string color;

        public Line(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public Station GetStation(string station)
        {
            for ( int i= 0; i < stations.Count; i++)
            {
                if ( stations[i].name == station)
                {
                    return stations[i];
                }
            }
            return new Station(station, "None");
            
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void AddStation(string name, string color, List<Station> transfers)
        {
            
            stations.Add(new Station(name, color, transfers));
        }
        public void AddStation(string name, string color)
        {
            stations.Add(new Station(name, color));
        }
        public void RemoveStation(string name)
        {
            for (int i = 0; i < stations.Count; i++)
            {
                if (stations[i].name == name)
                {
                    stations.RemoveAt(i);
                }
            }
        }
        public Station FindStationByName(string name)
        {
            for (int i = 0; i < stations.Count; i++)
            {
                if (stations[i].name == name)
                {
                    return stations[i];
                }
            }
            return new Station(name, "None");
        }
        public List<Station> GetStationList(string name)
        {
            Station temp = FindStationByName(name);
            return stations;
        }
    }
    public class Station
    {
        public string name;
        public string color;
        public Line line;
        public bool isWheelchairAccessible;
        public bool hasParkandRide;
        public bool hasNearbyCableCar;
        public List<Station> transfers;

        public Station(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public Station(string name, string color, List<Station> transfers)
        {
            this.name = name;
            this.color = color;
            this.transfers = transfers;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public bool IsWheelchairAccessible()
        {
            try
            {
                return isWheelchairAccessible;
            }
            catch
            {
                return false;
            }

        }
        public bool HasParkandRide()
        {
            try
            {
                return hasParkandRide;
            }
            catch
            {
                return false;
            }
        }
        public bool HasNearbyCableCar()
        {
            try
            {
                return hasNearbyCableCar;
            }
            catch
            {
                return false;
            }
        }
        public string GetLineName()
        {
            return line.name;
        }
        public List<Station> GetTransferList()
        {
            return transfers;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
