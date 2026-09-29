using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02_OOP_CSharp
{
    #region Question 2

    public class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                if (value != null && value != "" && value.Trim() != "")
                {
                    description = value;
                }
            }
        }

        public decimal Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }

            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        public DeliveryAddress Destination
        {
            get;
            set;
        }

        public virtual decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }

        public Shipment(string trackingCode)
        {
            this.trackingCode = "Unknown";
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);

            if (trackingCode != null && trackingCode != "" && trackingCode.Trim() != "")
            {
                this.trackingCode = trackingCode;
            }
        }

        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            this.trackingCode = "Unknown";
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;
            Destination = destination;

            if (trackingCode != null && trackingCode != "" && trackingCode.Trim() != "")
            {
                this.trackingCode = trackingCode;
            }

            if (description != null && description != "" && description.Trim() != "")
            {
                this.description = description;
            }

            if (weight > 0)
            {
                this.weight = weight;
            }

            if (deliveryFee > 0)
            {
                this.deliveryFee = deliveryFee;
            }
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                deliveryFee = newFee;
            }
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }

    #endregion
}
