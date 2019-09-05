using System;
using System.Activities;
using Technovert.DataFields.CoreActivities;
using Technovert.DataFields.Validators;

namespace DataFieldTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           var value = Console.ReadLine();
            Console.WriteLine(DataFieldValidator.CheckValidity(value, Technovert.DataFields.Infrastructure.Enums.DataFieldType.EmailAddress));
            ValidationActivity validation = new ValidationActivity
            {
                Type = new InArgument<string>("EmailAddress")
            };
            
            var k = Console.ReadLine();
        }
    }
}
