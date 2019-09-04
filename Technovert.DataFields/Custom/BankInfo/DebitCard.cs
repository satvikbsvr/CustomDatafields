using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.DataFields.Custom
{
    public class DebitCard : StringDataField
    {
        public DebitCard() : base() { }
        public DebitCard(string value) : base(value) { }

        public override void InitDataField()
        {
            this.IsRequired = false;
            this.Pattern = "^(?:4[0-9]{12}(?:[0-9]{3})?|[25][1-7][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\\d{3})\\d{11})$";
            this.Description = "To Store Debit Card Fields";
            this.IsPatternValidationRequired = true;
        }
    }
}
