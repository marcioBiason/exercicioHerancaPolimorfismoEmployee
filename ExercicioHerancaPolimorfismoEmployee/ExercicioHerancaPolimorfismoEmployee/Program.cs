﻿using System;
using System.Collections.Generic;
using ExercicioHerancaPolimorfismoEmployee.Entities;
using System.Globalization;

namespace ExercicioHerancaPolimorfismoEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of Employees: ");
            int nOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nOfEmployees; i ++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outSourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outSourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Payments");
            foreach(Employee emp in list)
            {
                Console.WriteLine( emp.Name + " - $" + emp.Payment().ToString("F2",CultureInfo.InvariantCulture) );
            }
        }
    }
}
