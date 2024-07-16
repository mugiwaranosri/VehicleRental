using System;

class Program
{
    static void Main(string[] args)
    {
        RentalAgency agency = new RentalAgency();

        Car car1 = new Car("Model S", "Porsche", 2022, 150m, 5, "Electric", "Automatic", true);
        Truck truck1 = new Truck("Mustang", "Ford", 2021, 100m, 3.5, "Pickup", true);
        Motorcycle bike1 = new Motorcycle("Ninja", "Kawasaki", 2020, 80m, 650, "Gasoline", true);

        agency.AddVehicle(car1);
        agency.AddVehicle(truck1);
        agency.AddVehicle(bike1);

        agency.DisplayFleet();

        agency.RentVehicle(car1, 5);

        agency.DisplayFleet();
    }
}
