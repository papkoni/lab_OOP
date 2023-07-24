using System;
using System.Xml.Linq;

namespace second_lab;

public partial class Loud
{
    public void Loading()
    {
        Console.WriteLine("Loading...");
    }

}

class Car
{

    public static byte countObject = 0; //how much Object I have
    private readonly byte _id;  //readonly field
    private string _brand { get; set; } = string.Empty;
    private string _model { get; set; }
    private string _color { get; set; }
    private uint _registrationNumber { get; set; }
    public const byte wheelCount = 4; // добавитть в вывод

    private int _yearOfRelease = 0;
    public int YearOfRelease {
        get
        {
            return _yearOfRelease;
        }

        internal set
        {
            _yearOfRelease = value;
        }
    }







    //--------------------------------------------METODS---------------------------------------------------------
    
    public void WriteInf()
    {

   
        Console.WriteLine($"brand: {_brand}");
        Console.WriteLine($"model: {_model}");
        Console.WriteLine($"id: {_id}");
        Console.WriteLine($"year of release: {_yearOfRelease}");
        Console.WriteLine($"registration number: {_registrationNumber}");
        Console.WriteLine($"count of wheel: {wheelCount}");
        Console.WriteLine("-------------------------------\n");

    }

    public int HowOldCar(ref int currentYear) {
        int HowOldCar = currentYear - YearOfRelease;
        Console.WriteLine(HowOldCar);
        return HowOldCar;
    }

    public static void ListCarByBrend(Array array, string brand)
    {
        //Console.WriteLine("array: " + array);
        Console.WriteLine($"\nList {brand}:\n");
        foreach (Car car in array)
        {
            if(car._brand == brand) {
                car.WriteInf();
            }
        }
    }

    public static void ListCarByModels(Array array, string model, int year)
    {
        //Console.WriteLine("array: " + array);
        Console.WriteLine($"\nList {model} which create after {year}:\n");
        foreach (Car car in array)
        {
            if (car._model == model && car._yearOfRelease >= year)
            {
                car.WriteInf();
            }
        }
    }

    //-----------------------------------------------------------------------------------------------------
    //overriding the method of the Object class 

    //Equals:
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Car carEquals = (Car)obj;

        return _color == carEquals._color && _registrationNumber == carEquals._registrationNumber;
    }

    //GetHashCode:
    public override int GetHashCode()
    {
        return HashCode.Combine(_color, _registrationNumber);
    }
    // применить этот метод в главном классе и захуярить в консоль (хуй знает будет ли работать)

    //ToString
    public override string ToString()
    {
        return $" Registration number this car is {_registrationNumber} and color is {_color} ";
    }
    // применить этот метод в главном классе  и захуярить в консоль (хуй знает будет ли работать)



    //-------------------------------------------CONSTRUCTORS----------------------------------------------------------



    static Car()
    {
        Console.WriteLine("Caaaaaaaaars!"); //static constructor
    }

    public Car()  //without arguments
    {

        _id = (byte)_brand.GetHashCode();
        WriteInf();
        countObject++;
    }

    public Car( string brand, int yearOfRelease, string color, uint registrationNumber, string model ) //with  arguments
    {
        _id = (byte)brand.GetHashCode();
        _brand = brand;
        _yearOfRelease = yearOfRelease;                         
        _color = color;
        _registrationNumber = registrationNumber;
        _model = model;
        WriteInf();
        countObject++;


    }

    public Car( string brand, string model , int yearOfRelease = 2005 , string color = "black")  //with default argument
        {

        _model = model;
        _brand = brand;
        _id = (byte)brand.GetHashCode();
        _yearOfRelease = yearOfRelease;
        _color = color;
        Random rand = new Random();
        _registrationNumber = (uint)rand.Next(1000000, 9999999);
        WriteInf();
        countObject++;

    }


    private Car(string brand) // private constructor
    {
        this._brand = brand;

        countObject++;
        
    }

    public static Car CreateCarWithBrand(string brand) // определенный brand
    {
        return new Car(brand);
    }

}

class Program
{
    static void Main(string[] args)
    {
        int currentYear = 2023;

        Car objectWithoutArguments = new();
        Car objectWithDefaultArguments = new("bmw", "sidan");

        var privatCar = Car.CreateCarWithBrand("Opel");

        Car[] allCar = new Car[]
            {
                new("mers", 2008, "red", 1234567, "universal"),
                new("mustang", 2013, "black", 0765487, "universal" ),
                new("audi", 2020, "pink", 8345621, "universal"),
            };


        Console.WriteLine($"Count of object: {Car.countObject}");


        allCar[0].HowOldCar(ref currentYear);
        Car.ListCarByBrend(allCar, "mers");
        Car.ListCarByModels(allCar, "universal", 2016);

        bool areEqual = allCar[0].Equals(allCar[1]);
        if (areEqual)
        {
            Console.WriteLine("objects are equal");
        }
        else
        {
            Console.WriteLine("object aren't equal");
        }

        Console.WriteLine( $"тип созданного объекта: {objectWithoutArguments.GetType()}");
        var anonymousCar = new { id = 123, brand = "Lada", model = "sidan", color = "white", registrationNumber = 2343235};
        Console.WriteLine($"anonymousCar inf:\n id:{anonymousCar.id} \n brand: {anonymousCar.brand} \n model: {anonymousCar.model} \n color: {anonymousCar.color}, \n registration number: {anonymousCar.registrationNumber} ");
        Loud loud = new();
        loud.Loading();
        loud.Calling();

        Console.ReadKey();
    }


}
