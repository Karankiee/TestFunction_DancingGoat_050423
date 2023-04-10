using CMS.EventLog;
using DancingGoat.FormComponents;
using Kentico.Forms.Web.Mvc;
using System;

[assembly: RegisterFormValidationRule("CompareButBasicValidationRules", typeof(CompareButBasicValidationRules), "CompareButBasicValidationRules", Description = "CompareButBasicValidationRules")]

namespace DancingGoat.FormComponents
{
    [Serializable]
    public class CompareButBasicValidationRules : CompareToFieldValidationRule<string>
    {
        public override string GetTitle()
        {
            return $"Compare But Basic";
        }
        protected override bool Validate(string value)
        {
            EventLogProvider.LogInformation("CompareButBasicValidationRules", $"value ==> {value}", "0");

            if (value == "Compare")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
