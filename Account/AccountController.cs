using Utility;
using Google.Cloud.Firestore;
using System.Security.Principal;
using System.Diagnostics;

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

        public void CreateTransaction(TransactionModel _transactionData,out string msg)
        {
            try
            {
                CollectionReference collection = _db.Collection("transaction");
                Dictionary<string, object> transaction = new Dictionary<string, object>()
                {
                        { "type",_transactionData.Type},
                        {"amount",_transactionData.Amount},                   
                        {"created", FieldValue.ServerTimestamp}

                };

                switch (_transactionData.Type)
                {
                    case (int)TransactionType.Type.DEPOSIT:
                        transaction.Add("destination", _transactionData.Destination);
                        transaction.Add("fee", _transactionData.Fee);
                        break;
                    case (int)TransactionType.Type.WITHDRAW:
                        transaction.Add("origin", _transactionData.Origin);
                        break;
                    case (int)TransactionType.Type.TRANSFER:
                        transaction.Add("destination", _transactionData.Destination);
                        transaction.Add("origin", _transactionData.Origin);
                        break;
                    case (int)TransactionType.Type.ADJUST:
                        transaction.Add("destination", _transactionData.Destination);
                        break;
                    default:
                        break;
                }

                collection.AddAsync(transaction);
                msg = "Transaction successfully created";
                //return true;
            }
            catch (Exception ex)
            {
                msg = ex.ToString();
               //return false;
            }
        }
    }
}