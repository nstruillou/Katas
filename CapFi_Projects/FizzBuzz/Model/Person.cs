namespace FizzBuzz.Model
{
    public abstract class Person
    {
        public Person(int personId)
        {
            this.PersonID = personId;
        }

        public int PersonID { get; private set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
    }
}