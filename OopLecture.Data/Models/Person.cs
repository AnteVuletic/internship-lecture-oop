namespace OopLecture.Data.Models
{
    public  class Person
    {
        public Person()
        {
            DataStore.PartyPeople.Add(this);    
        }

        public string Oib { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{Oib} - {Name} - {LastName}";
        }
    }
}
