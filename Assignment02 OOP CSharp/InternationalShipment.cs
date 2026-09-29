using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02_OOP_CSharp
{
    #region Question 5

    public class InternationalShipment : Shipment
    {
        private string destinationCountry;
        private decimal customsFee;

        public string DestinationCountry
        {
            get
            {
                return destinationCountry;
            }

            set
            {
                if (value != null && value != "" && value.Trim() != "")
                {
                    destinationCountry = value;
                }
            }
        }

        public decimal CustomsFee
        {
            get
            {
                return customsFee;
            }

            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + CustomsFee;
            }
        }

        public InternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.destinationCountry = "Unknown";
            this.customsFee = 0;

            if (destinationCountry != null &&
                destinationCountry != "" &&
                destinationCountry.Trim() != "")
            {
                this.destinationCountry = destinationCountry;
            }

            if (customsFee >= 0)
            {
                this.customsFee = customsFee;
            }
        }
    }

    #endregion
}
