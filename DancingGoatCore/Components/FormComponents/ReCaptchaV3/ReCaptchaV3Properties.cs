using CMS.DataEngine;
using CMS.SiteProvider;
using Kentico.Forms.Web.Mvc;

namespace DancingGoat.FormComponents.ReCaptchaV3
{
    public class ReCaptchaV3Properties : FormComponentProperties<string>
    {
        public ReCaptchaV3Properties() : base(FieldDataType.Text, size: 2000)
        {
            DefaultValue = "";
            GoogleSecretKey = _googleSecretKey;
        }


        static string _googleSiteKey = "";
        static string _googleSecretKey = GoogleSecretKey;

        public static string GoogleSiteKey
        {
            get
            {
                return SettingsKeyInfoProvider.GetValue("reCaptchaV3SiteKey", SiteContext.CurrentSiteID);

            }
            set
            {
                _googleSiteKey = value;
            }
        }

        public static string GoogleSecretKey
        {
            get
            {
                return SettingsKeyInfoProvider.GetValue("reCaptchaV3SecretKey", SiteContext.CurrentSiteID);
            }
            set
            {
                _googleSecretKey = value;
            }
        }

        [DefaultValueEditingComponent(TextInputComponent.IDENTIFIER)]
        public override string DefaultValue
        {
            get;
            set;
        }
    }
}
