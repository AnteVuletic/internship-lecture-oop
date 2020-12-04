using System;
using System.Collections.Generic;

namespace OopLecture
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. Create class object name student and professional and show they 
            // fit into same list of people.

            var people = new List<Person>();

            var economyStudent = new Student
            {
                Name = "Jure",
                LastName = "Jurić",
                Oib = "JURIN-OIB",
                University = UniversityType.Kopilica
            };

            var maritimeStudent = new Student
            {
                Name = "Okey definitivno ne Jure",
                LastName = "Jurić",
                Oib = "DEFINITIVNO-NE-JURE-OIB",
                University = UniversityType.Pomorski
            };

            var philosophyStudent = new Student
            {
                Name = "Nije Jure",
                LastName = "Jurić",
                Oib = "NIJE-JURE-OIB",
                University = UniversityType.Filozofski
            };

            var bestPersonEver = new Person
            {
                Name = "Matija",
                LastName = "Luketin",
                Oib = "MATIJIN-OIB"
            };

            var professionalSinger = new Professional
            {
                Name = "Marko",
                LastName = "Tompson",
                Oib = "TOMPSON-OIB",
                HourlyRate = 30.00m
            };

            people.Add(economyStudent);
            people.Add(philosophyStudent);
            people.Add(maritimeStudent);
            people.Add(bestPersonEver);
            people.Add(professionalSinger);

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            foreach (var person in DataStore.PartyPeople)
            {
                Console.WriteLine(person);
            }

            PrettyPrint.PrettyPrintPeople(people);

            var oldTownSplit = new Venue
            {
                Capacity = 2000,
                HourlyRate = 5000m,
                Location = "Split, Stari Plac",
                TicketPrice = 50m
            };

            var soloConcert = new SoloConcertEvent
            {
                StartDateTime = new DateTime(2021, 8, 25, 14, 0, 0),
                EndDateTime = new DateTime(2021, 8, 25, 18, 0, 0),
                Name = "Koncert Tompsona",
                Singer = professionalSinger,
                Venue = oldTownSplit
            };

            Console.WriteLine(soloConcert);

            var hourlyBudgetCalculator = new HourlyBudgetCalculator
            {
                TimeSpanInHours = soloConcert.GetTimespanInHours(),
                HourlyRates = new List<IHourlyRateable>
                {
                    oldTownSplit,
                    professionalSinger
                }
            };

            Console.WriteLine($"Budget calculator hours: {hourlyBudgetCalculator.TotalCost()}");
            Console.ReadLine();
        }
    }
}