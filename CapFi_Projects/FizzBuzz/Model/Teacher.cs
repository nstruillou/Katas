namespace FizzBuzz.Model
{
    public class Teacher : Person
    {
        public Teacher(int teacherId)
            : base(teacherId)
        {
        }

        public Discipline Discipline { get; set; }

        public string AskNumber(int number)
        {
            return "the " + this.Discipline.ToString().ToLower() + " teacher asks " + number.ToString();
        }
    }
}