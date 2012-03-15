﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverlightClientApp.Web.Model
{
    /// <summary>
    /// Describes an auto object
    /// </summary>
    public class Auto
    {
        /// <summary>
        /// Unique identifier of the auto
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Number of the auto
        /// </summary>
        public string Number { get; set; }


        /// <summary>
        /// Insuarance number of the auto
        /// </summary>
        public Insuarance Insuarance { get; set; }


        /// <summary>
        /// Model of the auto
        /// </summary>
        public Model Model { get; set; }


        /// <summary>
        /// category of the auto
        /// </summary>
        public Category Category { get; set; }


        /// <summary>
        /// Production year of the auto
        /// </summary>
        public short Year { get; set; }


        /// <summary>
        /// Current mileage of the auto
        /// </summary>
        public int Mileage { get; set; }


        /// <summary>
        /// Color of the auto
        /// </summary>
        public string Color { get; set; }


        /// <summary>
        /// Last check date of the auto
        /// </summary>
        public DateTime LastCheckDate { get; set; }


        /// <summary>
        /// Additional information about the auto
        /// </summary>
        public string Description { get; set; }
    }
}