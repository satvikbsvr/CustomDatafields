using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;
using static Technovert.DataFields.Validators.DataFieldValidator;
using Technovert.DataFields.Infrastructure;

namespace Technovert.DataFields.CustomActivities
{
    public class Validation : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<DataFieldType> InputDataType { get; set; }

        [Category("Input")]
        [RequiredArgument]
        public InArgument<dynamic> InputValue { get; set; }

        [Category("Output")]
        public OutArgument<bool> IsValid { get; set; }

        //[Category("Output")]
        //public OutArgument<DataFieldType> EnumDataType { get; set; }

        //[Category("Output")]
        //public OutArgument<DataFieldType> Enumcontext { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var enumtype = InputDataType.Get(context);
            var value = InputValue.Get(context);
            //DataFieldType datatype = (DataFieldType)Enum.Parse(typeof(DataFieldType), InputDataType.ToString());
            var isvalid = CheckValidity(value, enumtype);
            IsValid.Set(context, isvalid);
            //EnumDataType.Set(context, datatype);
        }    
    }
}
