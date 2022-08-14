using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car 
        public Car()
    {
    }
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDrivable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        Console.WriteLine(engineNoise);
    }
    public void MakeEngineNoise(string HonkNoise)
    {
        Console.WriteLine(HonkNoise);
    }

    var focus = new Car();
    focus.Make = "Ford";
    focus.Model = "focus";
    focus.Year = 2013;
    focus.EngineNoise = "vroom";
    focus.HonkNoise = "quiet";
    focus.IsDrivable = false;

        var hisCar = new Car()
        {
            Year = 2012,
            Make = "ford",
            Model = "F150",
            EngineNoise = "prrrrr",
            HonkNoise = "beeeeeeeeeeep",
            IsDriveable = True
        };
    lot.Cars.Add(focus);
        lot.Cars.Add(hisCar);




}
