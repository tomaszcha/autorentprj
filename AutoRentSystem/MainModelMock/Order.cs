﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainModelMock
{
    /// <summary>
    /// Describes rent order object
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Unique identifier of the rental order
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// The date of the order creation
        /// </summary>
        public DateTime CreationDate { get; set; }


        /// <summary>
        /// The date of the order closing
        /// </summary>
        public DateTime ClosingDate { get; set; }


        /// <summary>
        /// The auto to rent
        /// </summary>
        public Auto Auto { get; set; }


        /// <summary>
        /// The auto pick-up date
        /// </summary>
        public DateTime PickupDate { get; set; }


        /// <summary>
        /// The department of the auto pick-up
        /// </summary>
        public Department PickupDepartment { get; set; }
        

        /// <summary>
        /// The auto return date
        /// </summary>
        public DateTime ReturnDate { get; set; }

        
        /// <summary>
        ///  The department of the auto return
        /// </summary>
        public Department ReturnDepartment { get; set; }


        /// <summary>
        /// Status of the order
        /// </summary>
        public string Status { get; set; }


        /// <summary>
        /// Type of the rent
        /// </summary>
        public string RentType { get; set; }


        /// <summary>
        /// Type of the payment
        /// </summary>
        public string PaymentType { get; set; }


        /// <summary>
        /// Value of the payment
        /// </summary>
        public float Payment { get; set; }
    }
}
