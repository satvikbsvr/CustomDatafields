using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technovert.DataFields.Infrastructure;

namespace Technovert.DataFields.Validators
{
    public static class DataFieldValidator
    {
        public static bool CheckValidity(object o, Enums.DataFieldType type)
        {
            var dataField = DataFieldFactory.Create(type);
            dataField.Value = o;
            return dataField.IsValid;
        }
    }
}
