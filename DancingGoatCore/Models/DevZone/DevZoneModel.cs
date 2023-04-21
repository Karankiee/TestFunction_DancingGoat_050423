using Microsoft.Build.Framework;
using System.Collections.Generic;

namespace DancingGoat.Models.DevZone
{
    public class DevZoneModel
    {
        public class RegModel
        {
            // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
            public class Image
            {
                public string Name { get; set; }
                public string base64 { get; set; }
            }

            public class Root
            {
                public string Subject { get; set; }
                public string TitleName { get; set; }
                public string Name { get; set; }
                public string SurName { get; set; }
                public string Email { get; set; }
                public string Phone { get; set; }
                public string Detail { get; set; }
                public List<Image> Image { get; set; }
            }
        }

        public class eFormModel
        {
            public class Dropdownlist
            {
                public List<Subject_list> subjectList { get; set; }
                public List<TitleName_list> titleList { get; set; }
            }
            public class Subject_list
            {
                public string Text { get; set; }
                public string Category { get; set; }
            }
            public class TitleName_list
            {
                public string Text { get; set; }
                public string Category { get; set; }
            }
        }



    }
}
