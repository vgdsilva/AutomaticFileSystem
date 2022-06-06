using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using static FileDados.Utils.EnumDescrition;


namespace FileDados.Utils
{
    public static class ObjectExtensions
    {

        public static string GetEnumDescription(this Enum enumVal)
        {
            try
            {
                if (enumVal == null)
                    return string.Empty;

                var typeInfo = enumVal.GetType().GetTypeInfo();
                var v = typeInfo.DeclaredMembers.FirstOrDefault(x => x.Name == enumVal.ToString());
                EnumDescrition customAttribute = v?.GetCustomAttribute<EnumDescrition>();
                if (customAttribute == null)
                    return string.Empty;
                return customAttribute.Descrition;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

    }
}
