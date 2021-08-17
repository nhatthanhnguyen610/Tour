using Tour.Base;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Tour.Common.Constants
{
    public static class Constants
    {
        public const string SecretKey = "SecretKey";
        public const string TypeLanguage = "Language";
        public const string Authorization = "Authorization";
        public const string AppSettings = "AppSettings";
        public const string Logging = "Logging";
        public const string LogLevel = "LogLevel";
        public const string LogPath = "C:\\erp_log\\";
        public const string Issuer = "http://dsoft.software";
        public const string Audience = "http://erp-admin.dsoft.software";
        public const string ContentTypeJson = "application/json";
        public const string ContentTypeFormdata = "multipart/form-data";
        public const string No_Image = "/assets/image/no_image_available.jpg";
        public static string UserCde{ get; set; }      
        public static string FullName { get; set; }
        public static string Avatar { get; set; }
		public const string MasterCde="MQL00001";
        public static List<SysMenuOfUser> ListMenuOfUser { get; set; }
        public const string KHACHLE = "KHACHLE";

    }
    public static class MasterListGroupCode
    {
        public const string LanguageType = "LanguageType";
    }
    public static class SelectCode
    {
        public const string CountryCde = "CountryCde";
        public const string CountryName = "CountryName";
    }
    public static class DropDown
    {
        public const string MasterListCode = "masterListCode";
        public const string MasterListCdeName = "masterListCdeName";
    }
    public static class LogConst
    {
        public const string TypeLogFile = ".html";
        public const string yyyMMdd = "yyyyMMdd";
        public const string ddMMyyyhhmmss = "dd/MM/yyyy HH:mm:ss - ";
        public const string InPut = "INPUT";
        public const string OutPut = "OUTPUT";
        public const string Error = "ERROR";
        public const string OpenP = "<p style=\"color:blue;\">";
        public const string CloseP = "</p>";
    }

    public static class ResultCode
    {
        public const string Failed = "0";
        public const string Success = "1";
        public const string Version = "4";
        public const string Exist = "2";
        public const string Approval = "3";
    }
    public static class PathServer
    {
        public const string FormatDateTime = "{0:yyyyMMddHHmmss}";
        public const string PNG = ".png";
        public const string JPG = ".jpg";
        public const string PDF = ".pdf";
        public const string DOCX = ".docx";
        public static string PathUpload = "Upload";
        public static string PathLink = "http://erp-admin.dsoft.software/Upload/";
        public static string PathMailTemplate = "http://210.2.98.74:8099/TemplateMail/email-template.html";
        public const string pathFileExport = @"C:/EXPORT/";
        public const string pathDir = @"C:/Dsoft/crm/admin/Upload/";
        public const string pathAvatar = @"Image/avatar/";
        public const string pathSlider = @"Image/slider/";
        public const string pathBlog = @"Image/blog/";
        public const string pathCustomer = @"Image/customer/";
        public const string pathProduct = @"Image/product/";
        public const string yyyyMMddhhmmssfff = "yyyyMMddhhmmssfff";
    }
    public static class ProductCde
    {
        public const string Id = "id";
        public const string ManuFacturerName = "manufacturerName";
        public const string GroupProductName = "groupProductName";
    }
    public static class CdeSelectList
    {
        public const string Id = "id";
        public const string Name = "name";
    }

    public static class StatusCde
    {
        public const string New = "New";
        public const string Processing = "Processing";
        public const string Complete = "Complete";
        public const string Cancel = "Cancel";
    }

    public static class Paiment
    {
        public const string Content = "Trả tiền cho nhà cung cấp";
    }
}
