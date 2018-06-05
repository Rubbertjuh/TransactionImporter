﻿using System.Collections.Generic;
using TransactionImpoter.Domain;

namespace TransactionImporter.DAL
{
    public interface IExporterRepository
    {
        List<Transaction> GetTransactionsAllContinents(int id);
        List<CustomerInfo> GetCustomersAllContinents(int id);
        List<Transaction> GetTransactionFilterContinent(string continent, int id);
        List<CustomerInfo> GetCustomersFilterContinent(string continent, int id);

    }
}
