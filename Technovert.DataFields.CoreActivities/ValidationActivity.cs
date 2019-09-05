using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;
using static Technovert.DataFields.Infrastructure.Enums;
using static Technovert.DataFields.Validators.DataFieldValidator;

namespace Technovert.DataFields.CoreActivities
{
    public class ValidationActivity : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> Type { get; set; }

        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> Value { get; set; }

        [Category("Output")]
        public OutArgument<bool> IsValid { get; set; }

        [Category("Output")]
        public OutArgument<string> OpType { get; set; }

        [Category("Output")]
        public OutArgument<string> OpEnumType { get; set; }

        [Category("Output")]
        public OutArgument<string>  OpValue { get; set; }


        protected override void Execute(CodeActivityContext context)
        {
            var type = Type.Get(context);
            var value = Value.Get(context);
            DataFieldType datatype = (DataFieldType)Enum.Parse(typeof(DataFieldType), type);
            var isvalid = CheckValidity(value, datatype);
            OpType.Set(context, type);
            OpEnumType.Set(context, datatype);
            OpValue.Set(context, value);
            IsValid.Set(context, isvalid);
        }    
    }
}