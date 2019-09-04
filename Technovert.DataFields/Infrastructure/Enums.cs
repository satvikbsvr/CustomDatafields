using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technovert.DataFields.Infrastructure
{
    public class Enums
    {
        public enum DataFieldType
        {
            #region Personal Info DataField Types
            InternationalPhoneNumber,
            EmailAddress,
            #endregion

            #region Document Number Info DataField Types
            PassportNumber_India,
            AdhaarCardNumber,
            #endregion

            #region Bank Info DataField Types
            CreditCard,
            DebitCard,
            IFSCCode
            #endregion
        }
    }
}
