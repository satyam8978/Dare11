using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CricketBooking.Models
{
    public class AppTransaction
    {
        public string SDT_sStatus { get; set; } // For Transaction Success or Failed
        public DataTable SDT_dtTable { get; set; } // For Transaction Returning DataTable
        public string SDT_sMsgDate { get; set; }//For Transaction DateTime
        public string SDT_sMsgOrValue { get; set; } // For Transaction Messages
        public int SDT_nValue { get; set; } // For Transaction Integer Retrun Values
        public long SDT_lnValue { get; set; } // For Transaction Long Return Values

        public string ReturnStringValue { get; set; }
        public string ReturnStringValue1 { get; set; }
        public string ReturnStringValue2 { get; set; }
        public int ReturnIntValue { get; set; }
        public long ReturnLongValue { get; set; }
        public string TransactionStatus { get; set; }
        public string ErrorMessage { get; set; }
    }
}