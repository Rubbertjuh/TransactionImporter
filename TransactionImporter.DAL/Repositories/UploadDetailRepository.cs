﻿using System;
using System.Collections.Generic;
using TransactionImpoter.Domain;

namespace TransactionImporter.DAL.Repositories
{
    public class UploadDetailRepository : IUploadDetailRepository
    {
        private readonly IUploadDetailContext _uploadDetailContext;

        public UploadDetailRepository(IUploadDetailContext userContext)
        {
            _uploadDetailContext = userContext;
        }

        public void UploadDetails(UploadDetail detail)
        {
            return _uploadDetailContext.UploadDetails(detail);
        }

        public void UploadDetailList()
        {
            throw new NotImplementedException();
        }
    }
}
