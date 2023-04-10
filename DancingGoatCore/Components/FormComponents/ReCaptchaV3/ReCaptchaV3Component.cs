using CMS.DataEngine;
using CMS.SiteProvider;
using DancingGoat.FormComponents.ReCaptchaV3;
using Kentico.Forms.Web.Mvc;

[assembly: RegisterFormComponent(ReCaptchaV3Component.IDENTIFIER, typeof(ReCaptchaV3Component), "ReCaptchaV3 Component", Description = "Custom ReCaptchaV3 component", IconClass = "icon-recaptcha", ViewName = "~/Components/FormComponents/ReCaptchaV3/_ReCaptchaV3.cshtml")]

namespace DancingGoat.FormComponents.ReCaptchaV3
{
    public class ReCaptchaV3Component : FormComponent<ReCaptchaV3Properties, string>
    {
        public const string IDENTIFIER = "ReCaptchaV3Component";

        // Specifies the property is used for data binding by the form builder
        [BindableProperty]
        // Used to store the value of the input field of the component
        public string Value { get; set; }

        public string GoogleSiteKey = SettingsKeyInfoProvider.GetValue("reCaptchaV3SiteKey", SiteContext.CurrentSiteID);


        // Gets the value of the form field instance passed from a view where the instance is rendered
        public override string GetValue()
        {
            return Value;
        }


        // Sets the default value of the form field instance
        public override void SetValue(string value)
        {
            Value = value;
        }
    }
}
