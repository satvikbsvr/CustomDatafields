using System;
using Technovert.DataFields.Validators;

namespace DataFieldTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           var value = Console.ReadLine();
            Console.WriteLine(DataFieldValidator.CheckValidity(value, Technovert.DataFields.Infrastructure.Enums.DataFieldType.DebitCard));
        }
    }
}
