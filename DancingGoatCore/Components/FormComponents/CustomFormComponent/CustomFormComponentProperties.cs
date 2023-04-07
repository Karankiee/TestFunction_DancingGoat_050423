using System.Collections.Generic;

using CMS.DataEngine;

using Kentico.Forms.Web.Mvc;


namespace DancingGoat.FormComponents
{
    public class CustomFormComponentProperties : FormComponentProperties<string>
    {
        // Initializes a new instance of the CustomFormComponentProperties class and configures the underlying database field
        public CustomFormComponentProperties() : base(FieldDataType.Text, size: 200)
        {
        }

        [DefaultValueEditingComponent(TextInputComponent.IDENTIFIER)]
        public override string DefaultValue
        {
            get;
            set;
        }
    }
}
