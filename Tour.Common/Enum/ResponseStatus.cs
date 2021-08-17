using System;
using System.Collections.Generic;
using System.Text;

namespace DSoftCRM.Common
{
    public enum ResponseStatus
    {
        OK,
        Unauthorized,
        NotFound,
        BadRequest,
        NoData,
        Required,
        Conflict,
        FailData,
        RequestTimeout,
        Version,
        Exist,
        ContentType,
        Approval
    }
}
