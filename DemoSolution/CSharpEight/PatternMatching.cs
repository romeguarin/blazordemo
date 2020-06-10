using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEight
{
    public class TollCalculator
    {
        public decimal CalculateToll(object vehicle) =>
            vehicle switch
            {
                Car c => 2.00m,
                Taxi t => 3.50m,
                Bus b when b.Capacity <= 20 => 5.00m,
                Bus b when b.Capacity > 20 => 10.00m,
                DeliveryTruck dt => 10.00m,
                { } => throw new ArgumentException(message: "Not a known vehicle type", paramName: nameof(vehicle)),
                null => throw new ArgumentNullException(nameof(vehicle))
            };
        public decimal CalculateTollNew(object vehicle) =>
            vehicle switch
            {
                Car => 2.00m,
                Taxi => 3.50m,
                Bus b => b.Capacity switch
                {
                    <= 20 => 5.00m,
                    > 20 => 10.00m
                },
                DeliveryTruck => 10.00m,
                not null => throw new ArgumentException(message: "Not a known vehicle type", paramName: nameof(vehicle)),
                null => throw new ArgumentNullException(nameof(vehicle))
            };
    }

    public class Car
    {
        public int Passengers { get; set; }
    }
    public class DeliveryTruck
    {
        public int GrossWeightClass { get; set; }
    }
    public class Taxi
    {
        public int Fares { get; set; }
    }

    public class Bus
    {
        public int Capacity { get; set; }
        public int Riders { get; set; }
    }
    class PatternMatching
    {
    }
}
