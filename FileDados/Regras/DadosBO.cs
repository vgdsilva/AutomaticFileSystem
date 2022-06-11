using FileDados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileDados.Regras
{
    public class DadosBO
    {
        private static string userName = Environment.UserName;
        string path = @$"C:\Users\{userName}\AutomaticFileSystem";
        string file = @$"C:\Users\{userName}\AutomaticFileSystem\AutomaticFileConfig.json";

        public Dados GetDadosBasic()
        {
            Dados dados = new Dados();
            dados.source_dir = @$"C:\Users\{userName}\Downloads";

            return dados;
        }

        public Dados GetDadosFromConfiguration()
        {
            Dados DadosJson;
            using (Stream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                if (File.Exists(file) && stream.Length > 0)
                {
                    string FileContent;
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        FileContent = reader.ReadToEnd();
                    }

                    DadosJson = JsonSerializer.Deserialize<Dados>(FileContent);

                }
                else
                {
                    DadosJson = GetDadosBasic();
                }
                
            }
            return DadosJson;
        }

        public void VerificaSeExisteArquivoDeConfiguracao()
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            
        }



    }
}
