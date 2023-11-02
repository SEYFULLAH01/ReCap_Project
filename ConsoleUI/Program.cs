﻿using Business.Concrete;
using DataAccess.Concrete.EnitiyFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
namespace ConsoleUI

{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car ID: " + car.CarId + ", Model Year: " + car.ModelYear + ", Daily Price: "+ car.DailyPrice);

            }
        }
    }
}