Vehicle Rental Management System

Overview

This project is a Vehicle Rental Management System developed using C#. The system demonstrates key object-oriented principles such as inheritance, abstraction, and encapsulation by modeling different types of vehicles and a rental agency.

Table of Contents

Overview

Features

Class Descriptions

Usage

Installation

Demo

Contributing

License

Features

Inheritance: Car, Truck, and Motorcycle classes inherit from a base Vehicle class.

Abstraction: Common vehicle properties and methods are abstracted in the Vehicle class.

Encapsulation: Properties are encapsulated with public getters and setters.

Polymorphism: Overridden methods in derived classes to display specific details.

Fleet Management: Add, remove, and rent vehicles from the fleet.

Class Descriptions

Vehicle Class

Properties: Model, Manufacturer, Year, RentalPrice

Methods: DisplayDetails

Car Class (inherits from Vehicle)

Additional Properties: Seats, EngineType, Transmission, Convertible

Methods: Overrides DisplayDetails

Truck Class (inherits from Vehicle)

Additional Properties: Capacity, TruckType, FourWheelDrive

Methods: Overrides DisplayDetails

Motorcycle Class (inherits from Vehicle)

Additional Properties: EngineCapacity, FuelType, HasFairing

Methods: Overrides DisplayDetails

RentalAgency Class

Properties: Fleet (list of vehicles), TotalRevenue

Methods: AddVehicle, RemoveVehicle, RentVehicle, DisplayFleet

Usage

Clone the Repository:


sh

Copy code

git clone https://github.com/yourusername/vehicle-rental-management-system.git

cd vehicle-rental-management-system

Build the Project:


Open the solution file in Visual Studio 2022.

Build the solution to restore dependencies and compile the code.

Run the Project:


Set Program.cs as the startup project.

Run the project to see the demonstration in the console.

Installation

Prerequisites:


Visual Studio 2022

.NET SDK

Setup:



Clone the repository.

Open the solution in Visual Studio.

Build and run the project.

Demo

A short video demonstrating the project can be found (https://conestoga.desire2learn.com/d2l/le/dropbox/1124726/1020587/DownloadSubmissionFile?fid=155294286&sid=12599103) here
