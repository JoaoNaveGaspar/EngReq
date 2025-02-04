﻿using System;
using Hapibee.Backend.Domain.SeedWork;

namespace Hapibee.Backend.Domain.Flights
{
    public sealed class Aircraft : Entity
    {
        private Aircraft()
        {
        }

        public Aircraft(string internalCode, string brand, string model, AverageFuelConsumption averageFuelConsumption,
            DateTime manufactureDate)
        {
            InternalCode = internalCode;
            Brand = brand;
            Model = model;
            AverageFuelConsumption = averageFuelConsumption;
            ManufactureDate = manufactureDate;
        }

        public string InternalCode { get; }
        public string Brand { get; }
        public string Model { get; }
        public AverageFuelConsumption AverageFuelConsumption { get; }
        public DateTime ManufactureDate { get; }
    }
}