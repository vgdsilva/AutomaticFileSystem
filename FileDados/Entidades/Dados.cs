using FileDados.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDados.Entidades
{
    public class Dados
    {
        
        public string source_dir { get; set; }
        public string destination_dir_image { get; set; }
        public string destination_dir_documents { get; set; }
        public List<PathDados> PathDados { get; set; } = new List<PathDados>();
    }


    public class PathDados
    {
        public string destination_dir { get; set; }
        public string name_contains { get; set; }
        public List<TiposArquivos> extencions { get; set; } = new List<TiposArquivos>();

    }
}
