namespace Simulation
{
	public class Car : Vehicle
	{
		private string brand;
		private string model;
		private double fuelCapacity;
		private double fuelFor1Km;
		private double currentFuel;

        public Car(string brand, string model, double fuelCapacity, double fuelFor1Km, double currentFuel,string color, int year):base(color,year)
        {
            this.brand = brand;
            this.model = model;
            this.fuelCapacity = fuelCapacity;
            this.fuelFor1Km = fuelFor1Km;
            this.currentFuel = currentFuel;
        }
        public string ShowInfo()
        {
            return$"{brand} {model} {Color} {Year}, Fuel Capacity: {fuelCapacity}l, Fuel for 1 km: {fuelFor1Km}l,  Current fuel: {currentFuel}l ";

        }

        //Masinin gedeceyi yolu burada teyin edir.
        public double infoKm = 10;


        public double Drive()
        {
            if (currentFuel>=(currentFuel = currentFuel - (fuelFor1Km * infoKm)))
            {
                return currentFuel;
            }
         
       
            return currentFuel;
        }
    }
}

