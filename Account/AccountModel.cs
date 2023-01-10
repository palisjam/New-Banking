using Google.Cloud.Firestore;

namespace Account
{
    [FirestoreData]
    public class AccountModel
    {
        [FirestoreProperty]
        public string FamilyName { get; set; }
        [FirestoreProperty]
        public string GivenName { get; set; }
        [FirestoreProperty]
        public string Email { get; set; }
        [FirestoreProperty]
        public object Created { get; set; }

        public AccountModel Set(string famalyName, string givenName, string email)
        {
            this.FamilyName = famalyName;
            this.GivenName = givenName;
            this.Email = email;
            return this;
        }
    }

    [FirestoreData]
    public class TransactionModel
    {
        [FirestoreProperty]
        public string Origin { get; set; }
        [FirestoreProperty]
        public string Destination { get; set; }
        [FirestoreProperty]
        public double Amount { get; set; }
        [FirestoreProperty]
        public double Fee { get; set; }
        [FirestoreProperty]
        public int Type { get; set; }
        [FirestoreProperty]
        public object Created { get; set;}
    }

    public class Amount
    {
        public double Net { get; set; }
        public double Fee { get; set; }

        public double Gross()
        {
            return Net + Fee;
        }
    }
}
