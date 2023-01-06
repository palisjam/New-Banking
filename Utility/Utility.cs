namespace Utility
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