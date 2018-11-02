using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_class
{
    
    public class Car
    {
        
       

        public int YearModel { get; set; }
        public string Make { get; set; }
        public int Speed { get; set; }
        public Car() { }

        public Car(int yearModel, string Make)
        {
            this.YearModel = YearModel = yearModel;
            this.Make = Make;
            this.Speed = 0;
        }
        public Car(int speed)
        {
            this.Speed = speed;
        }
        public void FerraiAccelerate()
        {
            Random getrandom = new Random();
            this.Speed += getrandom.Next(0, 20);
        }
        public void LamboAccelerate()
        {
            Random getrandom2 = new Random();
            this.Speed += getrandom2.Next(0, 19);
        }
        public void Brake()
        {
            this.Speed -= 5;
        }
    }
}   
