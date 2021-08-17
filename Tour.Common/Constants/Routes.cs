using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DSoftCRM.Common
{
    public class Routes
    {
        public static class UserManager
        {
            public const string path = "user-manager";
            public const string login = "login";
            public const string GetList = "get-list";
            public const string delete = "delete";
            public const string CreateUser = "create";
            public const string UpdateUser = "update";
            public const string GetInfo = "get-info";
            public const string Logout = "logout";
            public const string Change = "change";
            public static string GetRouteLogin()
            {
                return path + "/" + login;
            }
        }

        public static class MasterList
        {
            public const string Route = "master-list";
            public const string GetList = "get-list";
            public const string GetListByCode = "get-list-by-code";
            public const string Getinfo = "get-info";
            public const string Create = "create";
            public const string Update = "update";
            public const string Delete = "delete";
        }
        public static class Career
        {
            public const string Route = "career";
            public const string GetList = "get-list";
            public const string Getinfo = "get-info";
            public const string Create = "create";
            public const string Update = "update";
            public const string Delete = "delete";
        }
        public static class Address
        {
            public const string Route = "address";
            public const string GetListWard = "get-list-ward";
            public const string GetListProvince = "get-list-province";
            public const string GetListDistrict = "get-list-district";
        }

        public static class Expertise
        {
            public const string Route = "areas-expertise";
            public const string GetList = "get-list";
            public const string GetInfo = "get-info";
            public const string Delete = "delete";
            public const string Create = "create";
            public const string Update = "update";

        }

        public static class Recruiter
        {
            public const string Route = "recruiter";
            public const string GetList = "get-list";
            public const string Getinfo = "get-info";
            public const string Create = "create";
            public const string Update = "update";
            public const string Login = "login";
            public const string Delete = "delete";
            public const string Logout = "logout";
            public const string Change = "change";
            public const string Confirm = "confirm";
            public const string ResetPassword = "reset-password";
            public static string GetRouteLogin()
            {
                return Route + "/" + Login;
            }
            public static string GetRouteCreate()
            {
                return Route + "/" + Create;
            }

            public static string GetRouteConfirm()
            {
                return Route + "/" + Confirm;
            }
            public static string GetRouteGetList()
            {
                return Route + "/" + GetList;
            }

        }

        public static class JobSeeker
        {
            public const string Route = "jobseeker";
            public const string GetList = "get-list";
            public const string Getinfo = "get-info";
            public const string Create = "create";
            public const string Update = "update";
            public const string login = "login";
            public const string Delete = "delete";
            public const string Logout = "logout";
            public const string Change = "change";
            public const string Confirm = "confirm";
            public const string Reset = "reset";
            public const string GetListTopCtv = "get-list-top-ctv";
            public const string Related = "related";
            public static string GetRouteLogin()
            {
                return Route + "/" + login;
            }

            public static string GetRouteConfirm()
            {
                return Route + "/" + Confirm;
            }

            public static string GetRouteCreate()
            {
                return Route + "/" + Create;
            }
            
            public static string GetRouteGetList()
            {
                return Route + "/" + GetList;
            }

            public static string GetRouteGetInfo()
            {
                return Route + "/" + Getinfo;
            }

            public static string GetRouteRelated()
            {
                return Route + "/" + Related;
            }
        }
        public static class Job
        {
            public const string Route = "job";
            public const string GetList = "get-list";
            public const string Getinfo = "get-info";
            public const string Create = "create";
            public const string Update = "update";
            public const string login = "login";
            public const string Delete = "delete"; 
            public const string Approval = "approval";
            public const string NoApproval = "no-approval";
            public const string Related = "related";
            public const string Rating = "rating";

            public static string GetRouteRelated()
            {
                return Route + "/" + Related;
            }
        }
        public static class Comment
        {
            public const string Route = "comment";
            public const string GetList = "get-list";
            public const string Create = "create";
            public const string Update = "update";
            public const string login = "login";
            public const string Delete = "delete";
            public const string Approval = "approval";
            public const string GetInfo = "get-info";
            public const string LikeOrDisLike = "like-dislike";
        }

        public static class News
        {
            public const string Route = "news";
            public const string GetList = "get-list";
            public const string GetInfo = "get-info";
            public const string Create = "create";
            public const string Delete = "delete";
            public const string Update = "update";
            public const string Related = "related";

            public static string GetRouteRelated()
            {
                return Route + "/" + Related;
            }
        }

        public static class FavoriteJob
        {
            public const string Route = "favorite";
            public const string GetList = "get-list";
            public const string Create = "create";
            public const string Delete = "delete";
        }

        public static class TransactionJobSeeker
        {
            public const string Route = "transaction-job-seeker";
            public const string Create = "create";
            public const string GetInfo = "get-info";
            public const string GetList = "get-list";
            public const string Update = "update";
            public const string Delete = "delete";
        }
        public static class ProfileJobSeeker
        {
            public const string Route = "profile-job-seeker";
            public const string GetList = "get-list";
            public const string GetInfo = "get-info";
            public const string Create = "create";
            public const string Update = "update";
            public const string Delete = "delete";
            public const string DowloadsNumber = "downloads-number";
            public const string ViewsNumber = "views-number";


        }
        public static class TransactionRecruiter
        {
            public const string Route = "transaction-recruiter";
            public const string GetList = "get-list";
            public const string Approval = "approval";
            public const string Getinfo = "get-info";
            public const string Create = "create";
            public const string Update = "update";
            public const string Delete = "delete";
            public const string Request = "request";
        }

        public static class IntroductionHistory
        {
            public const string Route = "introduction-history";
            public const string Create = "create";
            public const string GetList = "get-list";
            public const string GetInfo = "get-info";
        }
        public static class Promotion
        {
            public const string Route = "promotion";
            public const string GetList = "get-list";
            public const string GetInfo = "get-info";
            public const string Create = "create";
            public const string Update = "update";
            public const string Delete = "delete";
        }
        public static class ExchangeRate
        {
            public const string Route = "exchange-rate";
            public const string GetList = "get-list";
            public const string GetInfo = "get-info";
            public const string Create = "create";
            public const string Update = "update";
            public const string Delete = "delete";
        }

        public static class Transaction
        {
            public const string Route = "transaction";
            public const string GetList = "get-list";
            public const string GetInfo = "get-info";
            public const string Approval = "approval";
            public const string BuyInfo = "buy-info";
            public const string PayIn = "pay-in";
            public const string Withdrawal = "with-drawal";
        }
        public static class ApplyJob
        {
            public const string Route = "apply-job";
            public const string GetList = "get-list";
            public const string GetInfo = "get-info";
            public const string Create = "create";
            public const string Update = "update";
            public const string Delete = "delete";
        }

        public static class ResetPassword
        {
            public const string Route = "reset-password";
            public const string Confirm = "confirm";
            public const string Request = "request";
            public const string Reset = "reset";

           

            public static string GetRouteConfirm()
            {
                return Route + "/" + Confirm;
            }

            public static string GetRouteRequest()
            {
                return Route + "/" + Request;
            }

            public static string GetRouteReset()
            {
                return Route + "/" + Reset;
            }

        }
        public static class JobseekerApproval
        {
            public const string Route = "jobseeker-approval";
            public const string RecruiterGetList = "recruiter-get-list";
            public const string JobSeekerGetList = "jobseeker-get-list";
            public const string StatusUpdate = "status-update";
            public const string Request = "request";
        }
        public static class CommentJobSeeker
        {
            public const string Route = "comment-job-seeker";
            public const string GetList = "get-list";
            public const string Create = "create";
        }
        public static class ComplainReport
        {
            public const string Route = "complain-report";
            public const string GetList = "get-list";
            public const string Create = "create";
            public const string Update = "update";
        }
    }
}
