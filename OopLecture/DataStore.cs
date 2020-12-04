using System.Collections.Generic;

namespace OopLecture
{
    public static class DataStore
    {
        public static IList<Person> PartyPeople { get; } = new List<Person>();
    }
}
