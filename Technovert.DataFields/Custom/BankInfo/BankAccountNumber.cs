using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.DataFields.Custom
{
    class BankAccountNumber : StringDataField
    {
        public BankAccountNumber() : base() { }

        public BankAccountNumber(string value) : base(value) { }

        public override void InitDataField()
        {
            Pattern = "[\\d]*";
            Description = "Bank account number";
            this.IsPatternValidationRequired = true;
        }
    }
}
