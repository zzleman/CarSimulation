namespace Simulation
{
	public class Vehicle
	{
		private string color;
		private int year;

        public Vehicle(string color, int year)
        {
            this.Color = color;
            this.Year = year;
        }

        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
    }
}

