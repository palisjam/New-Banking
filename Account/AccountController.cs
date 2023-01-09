﻿using Utility;
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
                CollectionReference collection = _db.Collection("transaction");

                if(_transactionData.Type == (int)TransactionType.Type.DEPOSIT)
                {
                    _transactionData.Fee = GetFee(_transactionData.Amount);
                    _transactionData.Amount = _transactionData.Amount - _transactionData.Fee;
                }
                collection.AddAsync(_transactionData);
                msg = "Transaction successfully created";
            }
            catch (Exception ex)
            {
                msg = ex.ToString();
            }
        }

        public double GetFee(double amount)
        {
            return Math.Round(amount * Fee, 2);

        }

        public async Task<AccountModel> GetAccount(string _iban)
        {
            AccountModel _account= new AccountModel();
            DocumentReference docRef = _db.Collection("account").Document(ValidateIBAN(_iban));
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                Dictionary<string, object> accDic = snapshot.ToDictionary();
                _account.Set(accDic["FamilyName"].ToString(), accDic["GivenName"].ToString(), accDic["email"].ToString());
            }
            return _account;
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