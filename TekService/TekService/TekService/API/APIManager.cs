using System;
using System.Collections.Generic;
using System.Text;

namespace TekService.API
{
    
    public static class APIManager
    {

    }

    public interface IMember
    {
        string Login();
        string List();
        string ForgotPassword();
        string UpdateDeviceInfo();
    }
}
