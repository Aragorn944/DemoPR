using System;

public class House
{
    // Properties of the house
    public string Address { get; set; }
    public int NumberOfRooms { get; set; }
    public double Price { get; set; }

    // Constructor to initialize the house object
    public House(string address, int numberOfRooms, double price)
    {
        Address = address;
        NumberOfRooms = numberOfRooms;
        Price = price;
    }

    // Method to display house details
    public void DisplayDetails()
    {
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Number of Rooms: {NumberOfRooms}");
        Console.WriteLine($"Price: ${Price}");
    }

    // Main method to test the class
    public static void Main(string[] args)
    {
        List<House> houses = new List<House>();

        // Create an instance of House
        House myHouse = new House("1234 Elm St", 3, 250000);
        houses.Add(myHouse);

        // Display details of the house
        myHouse.DisplayDetails();
    }
}
