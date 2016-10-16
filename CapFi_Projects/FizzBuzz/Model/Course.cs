namespace FizzBuzz.Model
{
    public abstract class Course
    {
        public Course(Discipline discipline)
        {
            this.Discipline = discipline;
        }

        public Discipline Discipline
        {
            get;
            private set;
        }
    }
}