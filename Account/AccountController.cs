using Utility;
using Google.Cloud.Firestore;

namespace Account
{
    public class AccountController
    {
        private FirestoreDb _db;
        public AccountController()
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"banking-70155-firebase-adminsdk-3l81z-63572a5941.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                _db = FirestoreDb.Create("banking-70155");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public bool CreateAccount(AccountModel _account, out string msg)
        {
            if (!String.IsNullOrEmpty(_account.IBAN))
            {
                try
                {
                    DocumentReference collection = _db.Collection("account").Document(_account.IBAN);
                    Dictionary<string, object> account = new Dictionary<string, object>()
                    {
                        { "FamilyName",_account.FamilyName},
                        {"GivenName",_account.GivenName},
                        {"email",_account.Email},
                        {"created", FieldValue.ServerTimestamp }

                    };
                    collection.SetAsync(account);
                    msg = "Account successfully created";
                    return true;
                }catch(Exception ex)
                {
                    msg = ex.ToString();
                    return false;
                }
            }
            else
            {
                msg = "Create account unsuccessful";
                return false;
            }
        }
    }
}