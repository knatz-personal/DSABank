﻿using System;
using System.Data.Entity;
using DataAccess.EntityModel;

namespace DataAccess
{
    public class DsaDataContext : DbContext
    {
        public DsaDataContext()
            : base("name=DefaultConnection")
        {
            //connection with highest database permissions
        }

        public DsaDataContext(String connectionString) : base("name=" + connectionString)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<AccountType> AccountTypes { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<ErrorLog> ErrorLogs { get; set; }

        public DbSet<EventLog> EventLogs { get; set; }

        public DbSet<FixedTermAccount> FixedTermAccounts { get; set; }

        public DbSet<FixedTerm> FixedTerms { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<InterestRate> InterestRates { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<TransactionType> TransactionTypes { get; set; }

        public DbSet<User> Users { get; set; }
    }
}