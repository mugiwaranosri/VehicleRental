using System;
using System.Collections.Generic;

public class RentalAgency
{
    private List<Vehicle> Fleet = new List<Vehicle>();
    public decimal TotalRevenue { get; private set; }

    public void AddVehicle(Vehicle vehicle)
    {
        Fleet.Add(vehicle);
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        Fleet.Remove(vehicle);
    }

    public void RentVehicle(Vehicle vehicle, int rentalDays)
    {
        if (Fleet.Contains(vehicle))
        {
            TotalRevenue += vehicle.RentalPrice * rentalDays;
            Fleet.Remove(vehicle);
            Console.WriteLine($"Rented {vehicle.Model} for {rentalDays} days. Total revenue: {TotalRevenue:C}");
        }
        else
        {
            Console.WriteLine($"Vehicle {vehicle.Model} is not available.");
        }
    }

    public void DisplayFleet()
    {
        foreach (var vehicle in Fleet)
        {
            vehicle.DisplayDetails();
            Console.WriteLine();
        }
    }
}
