using CMS.EventLog;
using Kentico.Forms.Web.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net;
using System;
using DancingGoat.FormComponents.ReCaptchaV3;

[assembly: RegisterFormValidationRule("ReCaptchaV3Validation", typeof(ReCaptchaV3Validation), "ReCaptcha V3 Validation", Description = "Validate reCaptcha V3 token.")]
namespace DancingGoat.FormComponents.ReCaptchaV3
{
    [Serializable]
    public class ReCaptchaV3Validation : CompareToFieldValidationRule<string>
    {
        public override string GetTitle()
        {
            return "ReCaptcha V3 Validation";
        }

        protected override bool Validate(string value)
        {

            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return false;
            }

            var gRecaptchaResponse = value.ToString();

            EventLogProvider.LogInformation("ReCaptchaV3Validation", "Result", gRecaptchaResponse);

            return ValidateToken(ReCaptchaV3Properties.GoogleSecretKey, gRecaptchaResponse);
        }

        public static bool ValidateToken(string googleSecretKey, string gRecaptchaResponse)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage res = httpClient.GetAsync($"https://www.google.com/recaptcha/api/siteverify?secret={googleSecretKey}&response={gRecaptchaResponse}").Result;
            string JSONres = res.Content.ReadAsStringAsync().Result;

            EventLogProvider.LogInformation("GoogleReCaptchaV3", "Result", JSONres);

            if (res.StatusCode != HttpStatusCode.OK)
            {
                return false;
            }
            else
            {
                dynamic JSONdata = JObject.Parse(JSONres);
                if (JSONdata.success != "true")
                {
                    return false;
                }
                return true;
            }
        }
    }
}

