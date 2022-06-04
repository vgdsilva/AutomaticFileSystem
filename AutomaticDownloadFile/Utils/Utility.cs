using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticDownloadFile.Utils
{
    public static class Utility
    {

        public static string GetDescritionFromEnum(Enum value)
        {
            DescriptionAttribute attribute = value.GetType().GetField(value.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false).SingleOrDefault() as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }



    }
}
