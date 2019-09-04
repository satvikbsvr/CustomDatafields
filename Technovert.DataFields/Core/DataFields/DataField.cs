using System;
using System.Text.RegularExpressions;
using Technovert.DataFields.Interfaces;

namespace Technovert.DataFields
{
    /// <summary>
    /// The DataField
    /// </summary>
    /// <seealso cref="Technovert.DataFields.Interfaces.IDataField" />
    public class DataField : IDataField
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is required.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the data field is required; otherwise, <c>false</c>.
        /// </value>
        public bool IsRequired { get; set; }
        
        /// <summary>
        /// Regular Expression pattern for checking if the data field is valid.
        /// </summary>
        /// <value>
        /// The pattern.
        /// </value>
        public string Pattern { get; set; }


        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Tells if the data field is valid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the data field is valid; otherwise, <c>false</c>.
        /// </value>
        public bool IsValid { get { return IsFieldValid(); } }

        public object Value { get; set; }

        public bool IsPatternValidationRequired { get; set; }


        /// <summary>
        /// Determines whether [is field valid].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is field valid]; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsFieldValid()
        {
            return (this.IsRequired && HasValue()) && !HasPatternValidation();
        }

        public bool HasPatternValidation()
        {
            return !string.IsNullOrEmpty(this.Pattern) && IsPatternValidationRequired;
        }

        public virtual bool HasValue()
        {
            return false;
        }
    }

    /// <summary>
    /// The Data Field of 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Technovert.DataFields.Interfaces.IDataField" />
    public class DataField<T> : DataField, IDataField<T>
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public new T Value { get => (T)base.Value; set => base.Value = value; }

        /// <summary>
        /// Gets or sets the default value.
        /// </summary>
        /// <value>
        /// The default value.
        /// </value>
        public T DefaultValue { get; set; }

        public DataField() : base()
        {
            InitDataField();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataField{T}"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public DataField(T value)
        {
            InitDataField();
            this.Value = value;
        }

        public DataField(T value, bool isRequired, bool isPatternValidationRequired = false, string pattern = "") {
            this.Value = value;
            this.IsRequired = IsRequired;
            this.IsPatternValidationRequired = isPatternValidationRequired;
            this.Pattern = Pattern;
        }

        public virtual void InitDataField()
        {
        }

        /// <summary>
        /// Determines whether [is field valid].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is field valid]; otherwise, <c>false</c>.
        /// </returns>
        public override bool IsFieldValid()
        {
            bool isValid = (IsRequired && HasValue()) || !IsRequired;

            try
            {
                if (isValid)
                {
                    if (HasValue() && HasPatternValidation())
                    {
                        isValid = Regex.IsMatch(Value.ToString(), this.Pattern);
                    }

                }
            }
            catch (Exception e)
            {
                //TO BE HANDLED
            }
            return isValid;

        }

        public override string ToString()
        {
            return Value?.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(T))
                return Value.Equals(obj);
            return false;
        }

        /// <summary>
        /// Determines whether this instance has value.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance has value; otherwise, <c>false</c>.
        /// </returns>
        public override bool HasValue()
        {
            return Value != null;
        }

    }
}
