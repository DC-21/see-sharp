// using System;

// namespace MyApp
// {
//     class Car
//     {
//         public string model;
//         public int year;
//         public string color;

//         public Car(String modelName, String modelColor, int modelYear)
//         {
//             model = modelName;
//             color = modelColor;
//             year = modelYear;
//         }

//         static void Main(String[] args)
//         {
//             Car ford = new Car("Mustang", "red", 1969);
//             Console.WriteLine(ford.color + " " + ford.model + " " + ford.year);
//         }
//     }
// }


using System;

namespace MyApp
{
    class Cars
    {
        string color = "red";

        static void Main(String[] args)
        {
            Cars newObj = new Cars();
            Console.WriteLine(newObj.color);
        }
    }
}
