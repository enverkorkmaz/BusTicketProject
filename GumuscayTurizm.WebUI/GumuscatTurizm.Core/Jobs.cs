using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscatTurizm.Core
{
    public static class Jobs
    {
        public static string CreateMessage(string title,string message,string alertType)
        {
            var alertMessage = new AlertMessage()
            {
                Title = title,
                Message = message,
                AlertType = alertType
            };
            return JsonConvert.SerializeObject(alertMessage);
        }
    }
}
