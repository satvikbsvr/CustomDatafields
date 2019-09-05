using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technovert.DataFields.Infrastructure;
using Technovert.DataFields.Interfaces;

namespace Technovert.DataFields
{
    public static class DataFieldFactory
    {
        public static T Create<T>() where T :IDataField,new()
        {
            return new T();
        }

        public static IDataField Create(DataFieldType type)
        {
            var DataFieldType = Type.GetType("Technovert.DataFields.Custom." + type.ToString(), throwOnError: false);

            if (DataFieldType == null)
            {
                throw new InvalidOperationException(type.ToString() + " is not a known datafield type");
            }

            if (!typeof(IDataField).IsAssignableFrom(DataFieldType))
            {
                throw new InvalidOperationException(DataFieldType.Name + " does not inherit from IDataField");
            }

            return (IDataField)Activator.CreateInstance(DataFieldType);
        }
    }
}
