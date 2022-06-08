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

        public Dados GetDadosFromConfiguration()
        {
            Dados dados = new Dados();
            dados.source_dir = @$"C:\Users\{userName}\Downloads";

            List<PathDados> Directorys = new List<PathDados>();
            Directorys.Add(new PathDados()
            {
                destination_dir = @$"C:\Users\{userName}\Pictures\",
            });

            Directorys.Add(new PathDados()
            {
                destination_dir = @$"C:\Users\{userName}\Documents\"
            });

            dados.PathDados = Directorys;

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

                List<Dados> configGeral = new List<Dados>();
                List<PathDados> Directorys = new List<PathDados>();
                Directorys.Add(new PathDados()
                {
                    destination_dir = @$"C:\Users\{userName}\Pictures\",
                });
                
                Directorys.Add(new PathDados()
                {
                    destination_dir = @$"C:\Users\{userName}\Documents\"
                });

                configGeral.Add(new Dados()
                {
                    source_dir = @$"C:\Users\{userName}\Downloads",
                    PathDados = Directorys
                });

                string json = JsonSerializer.Serialize(configGeral);

                using (var tw = new StreamWriter(file))
                {
                    
                    tw.WriteLine(json);
                    tw.Close();
                }
            }
        }



    }
}
