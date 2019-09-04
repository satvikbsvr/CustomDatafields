using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.DataFields.Custom
{
    public class IFSCCode : StringDataField
    {
        public IFSCCode() : base() { }

        public IFSCCode(string value) : base() { }

        public override void InitDataField()
        {
            this.Pattern = "^[A-Za-z]{4}\\d{7}$";
            this.Description = "To store IFSC code fields";
            this.IsPatternValidationRequired = true;
        }
    }
}
