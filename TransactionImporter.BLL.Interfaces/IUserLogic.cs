﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionImpoter.Domain;

namespace TransactionImporter.BLL
{
    public interface IUserLogic
    {
        void CreateUser(User user);
        void EditUser();
        void DeleteUser();
    }
}
