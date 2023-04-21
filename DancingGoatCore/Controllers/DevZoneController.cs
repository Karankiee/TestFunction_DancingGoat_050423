using CMS.Core;
using CMS.DataEngine;
using CMS.Helpers;
using CMS.MediaLibrary;
using CMS.OnlineForms;
using CMS.SiteProvider;
using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using Newtonsoft.Json;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using static DancingGoat.Models.DevZone.DevZoneModel;
using static DancingGoat.Models.DevZone.DevZoneModel.eFormModel;
using static NuGet.Packaging.PackagingConstants;

namespace DancingGoat.Controllers
{
    public class DevZoneController : Controller
    {
        IEventLogService eventLog = Service.Resolve<IEventLogService>();
        private readonly IPageUrlRetriever pageUrlRetriever;
        private readonly IHostingEnvironment _hostingEnvironment;


        public DevZoneController(IPageUrlRetriever pageUrlRetriever, IHostingEnvironment hostingEnvironment)
        {
            this.pageUrlRetriever = pageUrlRetriever;
            this._hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("/devzone")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/devzone/form")]
        public IActionResult Form()
        {
            //Dropdownlist dropdownlistModel = new Dropdownlist();
            //List<Subject_list> subject_Lists = new List<Subject_list>();
            //List<TitleName_list> titleName_Lists = new List<TitleName_list>();

            //var selectSubject = new DataQuery("customtable.E_formMasterQuery.selectSubject").Execute();
            //foreach (DataRow item in selectSubject.Tables[0].Rows)
            //{
            //    subject_Lists.Add(new Subject_list { Category = item["Category"].ToString(), Text = item["Text"].ToString() });
            //}

            //dropdownlistModel.subjectList = subject_Lists;

            //var selectTitleName = new DataQuery("customtable.E_formMasterQuery.selectTitleName").Execute();
            //foreach (DataRow item in selectTitleName.Tables[0].Rows)
            //{
            //    titleName_Lists.Add(new TitleName_list { Category = item["Category"].ToString(), Text = item["Text"].ToString() });
            //}

            //eventLog.LogError("devzone", "Form", JsonConvert.SerializeObject(dropdownlistModel));


            //return View(dropdownlistModel);
            return View();
        }

        [HttpPost("/devzone/savadata")]
        [ValidateAntiForgeryToken]
        public string SavaData([FromBody] RegModel.Root model)
        {
            try
            {
                //Server Site Validatetion
                if (!regxTextbox(model.Name, model.SurName, model.Phone) || model.Subject == "0" || model.TitleName == "0") return "Error";

                BizFormInfo formObject = BizFormInfoProvider.GetBizFormInfo("E_From4", SiteContext.CurrentSiteID);

                if (formObject != null)
                {
                    DataClassInfo formClass = DataClassInfoProvider.GetDataClassInfo(formObject.FormClassID);
                    string formClassName = formClass.ClassName;
                    BizFormItem newFormItem = BizFormItem.New(formClassName);
                    newFormItem.SetValue("Subject", model.Subject);
                    newFormItem.SetValue("TitleName", model.TitleName);
                    newFormItem.SetValue("Name", model.Name);
                    newFormItem.SetValue("SurName", model.SurName);
                    newFormItem.SetValue("Email", model.Email);
                    newFormItem.SetValue("Phone", model.Phone);
                    newFormItem.SetValue("Detail", model.Detail);

                    int index = 1;

                    foreach (var item in model.Image)
                    {
                        //only 5 image
                        if (index == 6) break;

                        string[] image = Base64ToImage(item.base64.Split(";base64,")[1]);
                        CreateFileMediaLib(image[0], $"image{index}", image[1]);
                        newFormItem.SetValue($"image{index}", image[0]);

                        index++;
                    }
                    newFormItem.Insert();

                    #region Send Mail
                    IBizFormMailSenderFactory senderFactory = Service.Resolve<IBizFormMailSenderFactory>();
                    IBizFormMailSender sender = senderFactory.GetFormMailSender(formObject, newFormItem);
                    sender.SendNotificationEmail();
                    #endregion
                }

                return "Success";
            }
            catch (Exception exx)
            {
                eventLog.LogError("devzone", "SavaData", $"Error => {exx.Message}");
                return "Error";
            }
        }

        public string[] Base64ToImage(string base64string)
        {
            string pathfile = $"{_hostingEnvironment.ContentRootPath}\\wwwroot\\eform";
            string fileName = $"{Guid.NewGuid()}.jpg";
            if (!Directory.Exists(pathfile))
            {
                Directory.CreateDirectory(pathfile);
            }

            string filePath = Path.Combine($"{pathfile}\\{fileName}");
            var base64array = Convert.FromBase64String(base64string);
            System.IO.File.WriteAllBytes(filePath, base64array);

            string[] result = new string[2];
            result[0] = fileName;
            result[1] = filePath;

            return result;
        }

        public void CreateFileMediaLib(string filename, string fileTitle, string filePath)
        {
            MediaLibraryInfo library = MediaLibraryInfo.Provider.Get("AuthLib", SiteContext.CurrentSiteID);

            if (library != null)
            {
                CMS.IO.FileInfo file = CMS.IO.FileInfo.New(filePath);

                if (file != null)
                {
                    // Creates a new media library file object
                    MediaFileInfo mediaFile = new MediaFileInfo(filePath, library.LibraryID);

                    // Sets the media library file properties
                    mediaFile.FileName = filename;
                    mediaFile.FileTitle = fileTitle;
                    mediaFile.FileDescription = "This file was created by DevZoneController.";
                    mediaFile.FilePath = "Folder1/";
                    mediaFile.FileExtension = file.Extension;
                    mediaFile.FileMimeType = MimeTypeHelper.GetMimetype(file.Extension);
                    mediaFile.FileSiteID = SiteContext.CurrentSiteID;
                    mediaFile.FileLibraryID = library.LibraryID;
                    mediaFile.FileSize = file.Length;

                    // Saves the media library file
                    MediaFileInfo.Provider.Set(mediaFile);

                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }
                }
            }
        }

        protected bool regxTextbox(string name, string suranme, string phoneNumber)
        {
            string regexPhoneNumber = @"^((0[6-9]\d{1}-\d{3}-\d{4})|(0[2-5|7]-\d{3}-\d{4}))$";
            string regexThai = @"^[ๅภถุคตู่จ้ข็ชๆไพีะรนึยืบฺลฃฟหกดเาสวงผปแอิทมใฝฎฑธํ๊ณฯญำฐฤฆฏโฌ็๋ษศซฉฮฺ์ฒฬฦั ]+$";

            if (!Regex.IsMatch(name, regexThai))
            {
                return false;
            }
            if (!Regex.IsMatch(suranme, regexThai))
            {
                return false;
            }
            if (!Regex.IsMatch(phoneNumber, regexPhoneNumber))
            {
                return false;
            }
            return true;
        }

    }
}
