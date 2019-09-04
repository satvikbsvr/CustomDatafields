using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.DataFields.Custom.DocumentNumbers
{
    public class PANCard : StringDataField
    {
        public PANCard() : base() { }
        public PANCard(string val) : base(val) { }

        public override void InitDataField()
        {
            this.Pattern = "^([A-Z]){5}([0-9]){4}([A-Z]){1}?$";
            this.Description = "Indian PAN card details";
            IsPatternValidationRequired = true;
        }
    }
}
