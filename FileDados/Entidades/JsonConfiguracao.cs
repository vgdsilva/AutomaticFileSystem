using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDados.Entidades
{
    public class JsonConfiguracao
    {

        public string SourceDirectory { get; set; }
        public List<JsonConfiguracaoOuthers> Directorys { get; set; }
    }

    public class JsonConfiguracaoOuthers
    {
        public string Dir_Directory { get; set; }
        public string Name_Content { get; set; }
        public List<string> Extensions { get; set; }
    }
}
