using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02_OOP_CSharp
{
    #region Question 3

    public class StandardShipment : Shipment
    {
        public StandardShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
    }

    #endregion
}
