using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Technovert.DataFields.Custom
{
    public class PassportNumber_India : StringDataField
    {
        public PassportNumber_India() : base() { }

        public PassportNumber_India(string value) : base(value) { }

        public override void InitDataField()
        {
            Pattern = "^[A-Z]{1}[0-9]{7}$";
            Description = "Indian Passport Number";
            this.IsPatternValidationRequired = true;
        }
    }
}
