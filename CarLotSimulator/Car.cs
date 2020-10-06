using System;
namespace CarLotSimulator
{
    public class Car
    {

        public Car()
        {
            CarLot.numberOfCars++;
            //ClassName.StaticMember
        }

        public Car(string make, string model, int year, string engineNoise)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsDriveable { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }

        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string honknoise)
        {
            Console.WriteLine(honknoise);
        }



    }

    
}
