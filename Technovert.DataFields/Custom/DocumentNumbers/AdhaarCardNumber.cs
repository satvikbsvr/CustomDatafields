using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.DataFields.Custom
{
    public class AdhaarCardNumber : StringDataField
    {
        public AdhaarCardNumber() : base() { }

        public AdhaarCardNumber(string value) : base(value) { }

        public override void InitDataField()
        {
            //this.Pattern = "^\\d{4}\\s\\d{4}\\s\\d{4}$";
            this.Pattern = "^\\d{12}";
            this.Description = "For adhaar card numbers";
            this.IsPatternValidationRequired = true;
        }
    }
}
