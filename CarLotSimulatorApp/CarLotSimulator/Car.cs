﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        //Done - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Done - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //Why does nothing go into the contsructor. 
        public Car() 
        {
            CarLot.numberOfCars++;
        }
        public Car(int year,
                   string make,
                   string model,
                   string engineNoise,
                   string honkNoise,
                   bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

            

        }     

        

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngingeNoise(string engineNoise) 
        {
            Console.WriteLine(engineNoise);
        }
        public void MakeHonkNoise(string honkNoise)
        {
        Console.WriteLine(honkNoise);
        }

    }
}