using System;

namespace Technovert.DataFields
{
    public class StringDataField : DataField<string>
    {
        public StringDataField() : base() { }

        public StringDataField(string value) : base(value) { }

        public StringDataField(string value, bool isRequired, bool isPatternValidationRequired = false, string pattern = "") : base(value, isRequired, isPatternValidationRequired, pattern) { }

        public string Format { get; set; }

        public override bool HasValue()
        {
            return !string.IsNullOrEmpty(Value);
        }
    }
}
