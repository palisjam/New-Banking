namespace Utility
{
    public class CONSTANT
    {
        public class ErrorCode
        {
            public enum Generic : int
            {
                ERROR_UNKNOWN = -1,
                SUCCESS = 200
            }
        }

        public class TransactionType
        {
            public enum Type : int
            {
                DEPOSIT = 100,
                WITHDRAW = 200,
                TRANSFER = 300,
                ADJUST = 400
            }
        }
    }
    public class GeneralMethod
    {
        public static double RoundUp(double input, int places)
        {
            double multiplier = Math.Pow(10, Convert.ToDouble(places));
            return Math.Ceiling(input * multiplier) / multiplier;
        }
    }
}