using Simulation;
Car car = new Car("Kia","Sorento",71,0.085,50,"Gray",2015);

Console.WriteLine(car.ShowInfo());
Console.WriteLine("After driving the road, current fuel is:" + " "+ car.Drive() + "l");