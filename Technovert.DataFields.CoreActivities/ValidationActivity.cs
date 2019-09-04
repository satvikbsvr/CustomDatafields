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


        protected override void Execute(CodeActivityContext context)
        {
            var type = Type.Get(context);
            var value = Type.Get(context);
            DataFieldType datatype = (DataFieldType)Enum.Parse(typeof(DataFieldType), type);
            var isvalid = CheckValidity(value, datatype);
            IsValid.Set(context, isvalid);
        }
    }
}