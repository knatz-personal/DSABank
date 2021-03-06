﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using SortOrder = System.Windows.Forms.SortOrder;

namespace WcfServiceDSABank
{
    [ServiceContract]
    public interface ITransactionServices
    {

        [OperationContract]
        IQueryable<string> ListAccountNumbers();

        [OperationContract]
        IQueryable<TransactionView> ListUserTransactions(string username);

        [OperationContract]
        IQueryable<TransactionView> FilterTransactions(string username, int accountNo,
            SortOrder order, DateTime? start, DateTime? end);

        [OperationContract]
        TransactionView GetTransactionDetails(int id);

        [OperationContract]
        IEnumerable<TransactionTypeView> GetTransactionTypes();

        [OperationContract]
        void TermDeposit(FixedAccountView accountInfo, TransactionView transactionInfo);


        [OperationContract]
        void PersonalTransfer(TransactionView item);

        [OperationContract]
        void LocalTransfer(TransactionView item);

        [OperationContract]
        void Delete(int id);
    }

    [DataContract]
    public class TransactionView
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int? AccountFromID { get; set; }

        [DataMember]
        public int? AccountToID { get; set; }

        [DataMember]
        public int? TypeID { get; set; }

        [DataMember]
        public string TypeName { get; set; }

        [DataMember]
        public DateTime DateIssued { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public string Currency { get; set; }

        [DataMember]
        public string Remarks { get; set; }
    }

    [DataContract]
    public class TransactionTypeView
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

}
