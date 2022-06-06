using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDados.Entidades
{
    public class Dados
    {
        private static string userName = Environment.UserName;
        public string source_dir = @$"C:\Users\{userName}\Downloads";
        public string destination_dir_image = @$"C:\Users\{userName}\Pictures\";
        public string destination_dir_documents = @$"C:\Users\{userName}\Documents\";


    }
}
