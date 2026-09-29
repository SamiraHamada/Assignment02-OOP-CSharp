namespace Assignment02_OOP_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 7
            Console.Write("Enter Delivery Center Name: ");
            string centerName = Console.ReadLine() ?? "";

            DeliveryCenter center = new DeliveryCenter(centerName);

            Console.WriteLine("\nEnter Standard Shipment Data");

            Console.Write("Tracking Code: ");
            string trackingCode = Console.ReadLine() ?? "";

            Console.Write("Description: ");
            string description = Console.ReadLine() ?? "";

            Console.Write("Weight: ");
            decimal weight = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Delivery Fee: ");
            decimal deliveryFee = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("City: ");
            string city = Console.ReadLine() ?? "";

            Console.Write("Street: ");
            string street = Console.ReadLine() ?? "";

            Console.Write("Building Number: ");
            int buildingNumber = int.Parse(Console.ReadLine() ?? "0");

            DeliveryAddress address = new DeliveryAddress(
                city,
                street,
                buildingNumber
            );

            StandardShipment standardShipment = new StandardShipment(
                trackingCode,
                description,
                weight,
                deliveryFee,
                address
            );

            center.AddShipment(standardShipment);

            Console.WriteLine("\nEnter Express Shipment Data");

            Console.Write("Tracking Code: ");
            trackingCode = Console.ReadLine() ?? "";

            Console.Write("Description: ");
            description = Console.ReadLine() ?? "";

            Console.Write("Weight: ");
            weight = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Delivery Fee: ");
            deliveryFee = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("City: ");
            city = Console.ReadLine() ?? "";

            Console.Write("Street: ");
            street = Console.ReadLine() ?? "";

            Console.Write("Building Number: ");
            buildingNumber = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine() ?? "0");

            address = new DeliveryAddress(
                city,
                street,
                buildingNumber
            );

            ExpressShipment expressShipment = new ExpressShipment(
                trackingCode,
                description,
                weight,
                deliveryFee,
                address,
                extraFee
            );

            center.AddShipment(expressShipment);

            Console.WriteLine("\nEnter International Shipment Data");

            Console.Write("Tracking Code: ");
            trackingCode = Console.ReadLine() ?? "";

            Console.Write("Description: ");
            description = Console.ReadLine() ?? "";

            Console.Write("Weight: ");
            weight = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Delivery Fee: ");
            deliveryFee = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("City: ");
            city = Console.ReadLine() ?? "";

            Console.Write("Street: ");
            street = Console.ReadLine() ?? "";

            Console.Write("Building Number: ");
            buildingNumber = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine() ?? "";

            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine() ?? "0");

            address = new DeliveryAddress(
                city,
                street,
                buildingNumber
            );

            InternationalShipment internationalShipment =
                new InternationalShipment(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    address,
                    destinationCountry,
                    customsFee
                );

            center.AddShipment(internationalShipment);

            Console.WriteLine("\n--- All Shipments ---");
            center.PrintAllShipments();

            Console.Write("Enter a tracking code to search: ");
            string searchCode = Console.ReadLine() ?? "";

            Shipment? foundShipment = center[searchCode];

            if (foundShipment != null)
            {
                Console.WriteLine("\nShipment found:");
                foundShipment.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            Console.Write("\nEnter a tracking code to remove: ");
            string removeCode = Console.ReadLine() ?? "";

            bool removed = center.RemoveShipment(removeCode);

            if (removed)
            {
                Console.WriteLine("Shipment removed successfully.");
            }

            Console.WriteLine("\n--- Remaining Shipments ---");
            center.PrintAllShipments();

            #endregion
        }
    }
}
