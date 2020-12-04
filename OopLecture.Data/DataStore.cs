using System.Collections.Generic;
using OopLecture.Data.Models;

namespace OopLecture.Data
{
    public static class DataStore
    {
        public static IList<Person> PartyPeople { get; } = new List<Person>();
    }
}
