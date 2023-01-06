namespace Account
{
    public class AccountModel
    {
        public string IBAN { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string Email { get; set; }

        public AccountModel Set(string iban, string famalyName, string givenName, string email)
        {
            this.IBAN = iban;
            this.FamilyName = famalyName;
            this.GivenName = givenName;
            this.Email = email;
            return this;
        }
    }
}
