namespace FizzBuzz.Interpretors
{
    public class FizzBuzzInterpretor : IFizzBuzzInterpretor
    {
        public string InterpretFizzBuzzNumber(int number)
        {
            string interpretedNumber = "";
            if (number % 3 == 0 || number % 5 == 0)
            {
                interpretedNumber = this.ConvertNumberToStringValue(number);
            }
            else
            {
                interpretedNumber += number.ToString();
            }

            return interpretedNumber;
        }

        private string ConvertNumberToStringValue(int number)
        {
            string convertedNumber = "";
            if (number % 3 == 0)
            {
                convertedNumber += "Fizz";
            }

            if (number % 5 == 0)
            {
                convertedNumber += "Buzz";
            }

            return convertedNumber;
        }
    }
}