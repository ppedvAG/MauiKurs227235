using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personendatenbank.Services
{
    public static partial class ToastService
    {
        public static partial bool ShowToast(string message, bool longToast)
        {
            new ToastContentBuilder().AddText(message).Show();
            return true;
        }
    }
}
