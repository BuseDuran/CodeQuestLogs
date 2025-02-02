namespace CodeQuest.Bootcamp.Math
{
    public class PowerOf
    {
        public string MathChallenge(int num)
        {
            //sayının 2'nin kuvveti olup olmadığını kontrol eden kodu yazınız.

            while (num > 1)
            {
                int res = num % 2;
                if (res != 0)
                    return "false";
                num /= 2;
            }
            return num == 1 ? "true" : "false";
        }
    }
}
