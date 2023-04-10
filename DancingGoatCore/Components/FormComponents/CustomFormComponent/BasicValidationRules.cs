using CMS.EventLog;
using CMS.SalesForce;
using DancingGoat.FormComponents;
using Kentico.Forms.Web.Mvc;
using System;

[assembly: RegisterFormValidationRule("BasicValidationRules", typeof(BasicValidationRules), "BasicValidationRules", Description = "BasicValidationRules")]
namespace DancingGoat.FormComponents
{
    [Serializable]
    public class BasicValidationRules : ValidationRule<string>
    {
        // Gets the title of the validation rule as displayed in the list of applied validation rules
        public override string GetTitle()
        {
            return "This title appears in the list of applied validation rules on the 'Validation' tab of individual form fields.";
        }


        // Contains custom validation logic
        // Invokes when validation occurs
        protected override bool Validate(string value)
        {
            EventLogProvider.LogInformation("BasicValidationRules", $"value == > {value}", "0");

            return false;
        }
    }
}
