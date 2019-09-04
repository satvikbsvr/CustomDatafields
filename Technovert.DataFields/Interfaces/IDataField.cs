namespace Technovert.DataFields.Interfaces
{
    public interface IDataField
    {
        bool IsValid { get; }

        bool IsRequired { get; set; }

        bool IsPatternValidationRequired { get; set; }

        string Pattern { get; set; }

        string Description { get; set; }

        object Value { get; set; }

        bool IsFieldValid();
    }

    public interface IDataField<T> : IDataField
    {
        new T Value { get; set; }

        T DefaultValue { get; set; }
    }
}
