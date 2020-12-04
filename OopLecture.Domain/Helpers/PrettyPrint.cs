using System;
using System.Collections.Generic;
using OopLecture.Data.Enums;
using OopLecture.Data.Models;

namespace OopLecture.Domain.Helpers
{
    public static class PrettyPrint
    {
        public static void PrettyPrintPeople(IList<Person> people)
        {
            foreach (var person in people)
            {
                PrettyPrintPerson(person);
            }
        }

        public static void PrettyPrintPerson(Person person)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            if (person is Student student)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                switch (student.University)
                {
                    case UniversityType.Kopilica:
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case UniversityType.Ekonomija:
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        break;
                    case UniversityType.Pomorski:
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case UniversityType.Filozofski:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            if (person is Professional)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }

            Console.WriteLine(person);
            Console.ResetColor();
        }
    }
}
