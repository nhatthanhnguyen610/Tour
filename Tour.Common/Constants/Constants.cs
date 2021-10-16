using Tour.Base;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Tour.Common.Constants
{
    public static class Constants
    {
        public const string TypeLanguage = "Language";
        public const string AppSettings = "AppSettings";
        public const string Logging = "Logging";
        public const string ContentTypeJson = "application/json";
        public const string ContentTypeFormdata = "multipart/form-data";
        public const string No_Image = "/assets/image/no_image_available.jpg";
        public static string UserCde{ get; set; }      
        public static string FullName { get; set; }
        public static string Avatar { get; set; }
        public static string Password { get; set; }
		public const string MasterCde="MQL00001";
        public static List<SysMenuOfUser> ListMenuOfUser { get; set; }
        public const string KHACHLE = "KHACHLE";
    }
    public static class ResultStatus
    {
        public const string SUCCESS = "Thành công";
        public const string FAIL = "Không thành công";
        public const string ERROR = "Có lỗi trong quá trình xử lý";
        /// <summary>
        /// User
        /// </summary>
        public const string UserOldPass = "Nhập mật khẩu cũ không chính xác";
        public const string UserPassNotMatch = "Xác nhận mật khẩu không trùng nhau";
        public const string UserPassNull = "Mật khẩu không được để trống";
        public const string UserLoginNull = "Người dùng hoặc tên đăng nhập không được để trống";
        public const string UserLoginFail = "Đăng nhập không thành công";
        public const string UserEmailUsed = "Email đã có người dùng";

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
        public const string pathFileExport = @"C:/EXPORT/";
        public const string pathDir = @"C:/Users/DELL/Documents/GitHub/Tour/Tour.Admin/wwwroot/assets/";
        public const string pathAvatar = @"image/avatar/";
        public const string pathSlider = @"Image/slider/";
        public const string pathBlog = @"Image/blog/";
        public const string pathCustomer = @"Image/customer/";
        public const string pathProduct = @"Image/product/";
        public const string yyyyMMddhhmmssfff = "yyyyMMddhhmmssfff";
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
}
