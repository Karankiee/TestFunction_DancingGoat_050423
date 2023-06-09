﻿using CMS.EventLog;
using DancingGoat.FormComponents;
using Kentico.Forms.Web.Mvc;
using System;

[assembly: RegisterFormValidationRule("ValueOfDependeeLiesBetweenValidationRule", typeof(ValueOfDependeeLiesBetween), "Value of another field is between", Description = "Checks whether the value of the selected field lies on the specified interval given by the value of the selected field and the specified boundary.")]
namespace DancingGoat.FormComponents
{
    [Serializable]
    public class ValueOfDependeeLiesBetween : CompareToFieldValidationRule<int>
    {
        // Defines a configuration interface for the rule
        // The 'EditingComponent' attribute specifies which form component is used as the property's value editor
        [EditingComponent(IntInputComponent.IDENTIFIER, Label = "Bound", Order = 0)]
        public int Bound { get; set; } = 0;


        // Gets the title of the validation rule as displayed in the list of applied validation rules
        public override string GetTitle()
        {
            return $"The submitted value must lie on the interval specified by the value of the selected field and {Bound}.";
        }


        // Validates the configured property values against the submitted value of the selected dependee field
        protected override bool Validate(int value)
        {
            EventLogProvider.LogInformation("ValueOfDependeeLiesBetweenValidationRule", $"value ==> {value}", "0");

            if (Bound > DependeeFieldValue)
            {
                return (DependeeFieldValue <= value) && (value <= Bound);
            }
            else
            {
                return (Bound <= value) && (value <= DependeeFieldValue);
            }
        }
    }
}
