namespace CodeQuest.Bootcamp.Math
{
    public class DivideFormat
    {
        public static string MathChallenge(int num1, int num2)
        {
            double result = ( double )num1 / num2;

            //format the result to 4 decimal places
            return result.ToString("N4");
        }
    }
}
