using FileDados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDados.Regras
{
    public class DadosBO
    {
        private static string userName = Environment.UserName;

        public Dados GetDadosFiles()
        {
            Dados dados = new Dados();
            dados.source_dir = @$"C:\Users\{userName}\Downloads";
            dados.destination_dir_image = @$"C:\Users\{userName}\Pictures\";
            dados.destination_dir_documents = @$"C:\Users\{userName}\Documents\";

            return dados;
        }



    }
}
