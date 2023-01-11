using Utility;
using Google.Cloud.Firestore;
using System.Security.Principal;
using System.Diagnostics;

namespace Account
{
    public class AccountController
    {
        private FirestoreDb _db;
        private double Fee = 0.001;

        public AccountController(double _fee = 0)
        {
            try
            {
                if (_fee > 0){ Fee = _fee; }
                string path = AppDomain.CurrentDomain.BaseDirectory + @"banking-70155-firebase-adminsdk-3l81z-63572a5941.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                _db = FirestoreDb.Create("banking-70155");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public bool CreateAccount(string iban, AccountModel _account, out string msg)
        {
            if (!String.IsNullOrEmpty(iban))
            {
                try
                {
                    DocumentReference collection = _db.Collection("account").Document(iban);
                    _account.Created = FieldValue.ServerTimestamp;
                    collection.SetAsync(_account);
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
                _transactionData.Created= FieldValue.ServerTimestamp;
                CollectionReference collection = _db.Collection("transaction");
                collection.AddAsync(_transactionData);
                msg = "Transaction successfully created";
            }
            catch (Exception ex)
            {
                msg = ex.ToString();
            }
        }

        public bool GetFee(double gross, out Amount _amount)
        {
            _amount = new Amount();
            _amount.Fee = GeneralMethod.RoundUp(gross * Fee, 2);
            _amount.Net = gross-_amount.Fee;
            return _amount.Net > 0;

        }

        public async Task<AccountModel> GetAccount(string _iban)
        {
            AccountModel _account= new AccountModel();
            DocumentReference docRef = _db.Collection("account").Document(ValidateIBAN(_iban));
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                Dictionary<string, object> accDic = snapshot.ToDictionary();
                _account.Set(accDic["FamilyName"].ToString(), accDic["GivenName"].ToString(), accDic["Email"].ToString());
            }
            return _account;
        }        

        public async Task<double> GetBalance(string _iban)
        {
            AccountModel _account = new AccountModel();
            TransactionModel _transaction = new TransactionModel();
            double _amount = 0;

            Query balanceQuery = _db.Collection("transaction").WhereEqualTo("Destination", _iban);
            QuerySnapshot balanceQuerySnapshot = await balanceQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in balanceQuerySnapshot.Documents)
            {
                Dictionary<string, object> tranDic = documentSnapshot.ToDictionary();
                _amount += (double)tranDic["Amount"];
            }

            balanceQuery = _db.Collection("transaction").WhereEqualTo("Origin", _iban);
            balanceQuerySnapshot = await balanceQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in balanceQuerySnapshot.Documents)
            {
                Dictionary<string, object> tranDic = documentSnapshot.ToDictionary();
                _amount -= (double)tranDic["Amount"];
            }

            return _amount;

        }

        public async Task<List<AccountSummaryModel>> GetAccountSummary()
        {
            List<AccountSummaryModel> _accSumList = new List<AccountSummaryModel> ();
            AccountSummaryModel _accSum;
            Query accountQuery = _db.Collection("account");
            QuerySnapshot accountQuerySnapshot = await accountQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot documentSnapshot in accountQuerySnapshot.Documents)
            {
                _accSum = new AccountSummaryModel();
                _accSum.IBAN = documentSnapshot.Id;
                _accSum.Balance = await GetBalance(_accSum.IBAN);
                _accSumList.Add(_accSum);
            }
            return _accSumList;
        }

        public string ValidateIBAN(string _iban)
        {
            if(_iban.Length<18|| String.IsNullOrEmpty(_iban))
            {
                return "0";
            }
            else
            {
                return _iban;
            }
        }
    }
}