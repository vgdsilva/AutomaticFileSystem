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
        string path = @$"C:\Users\{userName}\AppData\Roaming\AutomaticFileSystem";
        string file = @$"C:\Users\{userName}\AppData\Roaming\AutomaticFileSystem\AutomaticFileConfig.json";

        public Dados GetDadosFiles()
        {
            
            Dados dados = new Dados();
            dados.source_dir = @$"C:\Users\{userName}\Downloads";
            dados.destination_dir_image = @$"C:\Users\{userName}\Pictures\";
            dados.destination_dir_documents = @$"C:\Users\{userName}\Documents\";

            return dados;
        }

        public void VerificaSeExisteArquivoDeConfiguracao()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            else
            {
                List<JsonConfiguracao> configs = new List<JsonConfiguracao>();
                List<JsonConfiguracaoOuthers> Directorys = new List<JsonConfiguracaoOuthers>();
                Directorys.Add(new JsonConfiguracaoOuthers()
                {
                    Dir_Directory = @$"C:\Users\{userName}\Pictures\",
                });
                
                Directorys.Add(new JsonConfiguracaoOuthers()
                {
                    Dir_Directory = @$"C:\Users\{userName}\Documents\"
                });

                configs.Add(new JsonConfiguracao()
                {
                    SourceDirectory = @$"C:\Users\{userName}\Downloads",
                    Directorys = Directorys
                });

                string json = JsonSerializer.Serialize(configs);

                using (var tw = new StreamWriter(file))
                {
                    
                    tw.WriteLine(json);
                    tw.Close();
                }
            }
        }



    }
}
