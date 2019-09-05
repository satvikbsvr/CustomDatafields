using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technovert.DataFields.Infrastructure;
using Technovert.DataFields.Interfaces;

namespace Technovert.DataFields.Validators
{
    public static class DataFieldValidator
    {
        public static bool CheckValidity(object value, DataFieldType type)
        {
            var dataField = DataFieldFactory.Create(type);
            dataField.Value = value;
            return dataField.IsValid;
        }

        public static bool CheckValidity<T>(T value, bool isRequired, bool isPatternValidationRequired,string pattern)
        {
            var dataField = new DataField<T>(value, isRequired, isPatternValidationRequired, pattern);
            return dataField.IsValid;
        }

    }



}
