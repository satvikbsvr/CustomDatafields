using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.DataFields.Custom
{
    public class InternationalPhoneNumber : Technovert.DataFields.StringDataField
    {
        public InternationalPhoneNumber() : base() { }

        public InternationalPhoneNumber(string phone) : base(phone) { }

        public override void InitDataField()
        {
            this.IsRequired = true;
            this.Pattern = "^[+](?:[0-9]){6,14}[0-9]$";
            this.Description = "To Store international phone numbers with ISD codes";
            this.IsPatternValidationRequired = true;
        }
    }
}
