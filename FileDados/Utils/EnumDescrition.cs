using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDados.Utils
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class EnumDescrition : Attribute
    {

        public string Descrition { get; }

        public EnumDescrition(string descrition)
        {
            Descrition = descrition;
        }

        public class EnumValues
        {
            public long ID { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Value;
            }
        }
    }
}
