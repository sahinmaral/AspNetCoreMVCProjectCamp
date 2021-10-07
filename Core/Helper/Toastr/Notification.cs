using Core.Helper.Toastr.OptionEnums;

using System;
using System.ComponentModel;
using System.Reflection;

namespace Core.Helper.Toastr
{
    public static class Notification
    {
        #region HELPERS
        private static string stringValueOf(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }
        private static string booToLowerString(this bool value)
        {
            return value.ToString().ToLower();
        }
        #endregion


        public static string Show(string message, string title = "",
            ToastType type = ToastType.info,
            Position position = Position.BottomRight,
            int timeOut = 5000,
            bool closeButton = true,
            bool progressBar = true,
            bool newestOnTop = true,
            string onclick = null)
        {
            var scriptOption = "";

            scriptOption += "this.toastr.options = {";

            scriptOption += "'closeButton': '" + closeButton.booToLowerString() + "','debug': false,'newestOnTop': " + newestOnTop.booToLowerString() + ",'progressBar': " + progressBar.booToLowerString() + ",'positionClass': '" + stringValueOf(position) + "','preventDuplicates': false,'onclick': " + (onclick ?? "null") + ",'showDuration': '300','hideDuration': '1000','timeOut': '" + timeOut + "','extendedTimeOut': '1000','showEasing': 'swing','hideEasing': 'linear','showMethod': 'fadeIn','hideMethod': 'fadeOut'";
            scriptOption += "};";

            scriptOption += $"this.toastr.{stringValueOf(type)}('{message}');";

            return scriptOption;
        }
    }
}
