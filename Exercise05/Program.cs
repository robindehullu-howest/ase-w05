using Howest.MCT.Exercise05.Models;

Random random = new Random();
List<IVehicle> vehicles = new List<IVehicle>();

for (int i = 0; i < 10; i++) // Create a list of 10 random vehicles
{
    int vehicleType = random.Next(1, 4); // Generate a random number between 1 and 3

    // Create and add a random vehicle to the list
    switch (vehicleType)
    {
        case 1:
            vehicles.Add(new Car());
            break;
        case 2:
            vehicles.Add(new Truck());
            break;
        case 3:
            vehicles.Add(new Motorcycle());
            break;
    }

    var cars = vehicles.Where(v => v is Car).Cast<Car>().ToList();

    foreach (var car in cars)
    {
        car.Drive();
    }
}