using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public partial class Car
    {
        private int salary;
        private Color color;
        private int releaseYear;
        private string name;
        private string carModel;
        private static string category;
        private static int wheels;
        public Car()
        {
            name = "";
            carModel = "";
        }
        static Car()
        {
            category = "Car";
            wheels = 4;
        }
        public Car(Color color, int year)
        {
            this.color = color;
            releaseYear = year;
        }
        public Car(Color color, int year, int salary)
        {
            this.salary = salary;
            this.color = color;
            releaseYear = year;
        }
        public Car(Color color, int year, int salary,string name , string carModel)
        {
            this.salary = salary;
            this.color = color;
            releaseYear = year;
            this.name = name;
            this.carModel = carModel;
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int ReleaseYear
        {
            get { return releaseYear; }
            set { releaseYear = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string CarModel
        {
            get { return carModel; }
            set { carModel = value; }
        }
    }
}
