﻿using pdfforge.DataStorage;

namespace pdfforge.PDFCreator.Conversion.Settings
{
    public partial class FtpAccount
    {
        public string AccountInfo => UserName + "@" + Server;

        public void CopyTo(FtpAccount targetAccount)
        {
            var data = Data.CreateDataStorage();
            StoreValues(data, "");
            targetAccount.ReadValues(data, "");
        }
    }
}
