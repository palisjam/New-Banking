namespace Account
{
    public class AccountModel
    {
        public string IBAN { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string Email { get; set; }
        public string Created { get; set; }

        public AccountModel Set(string iban, string famalyName, string givenName, string email)
        {
            this.IBAN = iban;
            this.FamilyName = famalyName;
            this.GivenName = givenName;
            this.Email = email;
            return this;
        }
    }

    public class TransactionModel
    {
        public string Origin { get; set;}
        public string Destination { get; set;}
        public string Amount { get; set;}
        public string Fee { get; set;}
        public int Type { get; set;}
        public string Created { get; set;}
    }
}
