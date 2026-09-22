using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4
{
    internal class StandardShipment : Shipment
    {
        public override double EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }
        public StandardShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
    }
}