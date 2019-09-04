using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.DataFields.Custom
{
    public class EmailAddress : Technovert.DataFields.StringDataField
    {
        public EmailAddress() : base() { }
        public EmailAddress(string emailId) : base(emailId) { }

        public override void InitDataField()
        {
            this.IsRequired = true;
            this.Pattern = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
            this.Description = "To Store email addresses";
            this.IsPatternValidationRequired = true;
        }
    }
}
