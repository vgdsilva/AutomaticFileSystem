using FileDados.Entidades;
using FileDados.Enuns;
using FileDados.Regras;
using FileDados.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticFileService.ServiceBO
{
    public class AutomaticFileServiceBO
    {
        private Dados dados;

        private static List<TiposArquivos> images_extentions = new List<TiposArquivos> { TiposArquivos.PNG, TiposArquivos.JPG, TiposArquivos.JPEG };
        private static List<TiposArquivos> documents_extentions = new List<TiposArquivos> { TiposArquivos.DOC, TiposArquivos.PDF, TiposArquivos.DOCX, TiposArquivos.TXT, TiposArquivos.XLS, TiposArquivos.XLSX };


        public void IniciateFileService()
        {
            dados = new DadosBO().GetDadosFiles();

            var files = from file in Directory.EnumerateFiles(dados.source_dir) select file;
            foreach (var file in files)
            {
                string source_file = file.Replace($@"{dados.source_dir}\", " ");

                CheckImageFiles(file);
                CheckDocumentsFiles(file);
            }
        }

        public void VerificarArquivoDeConfiguracao()
        {
            new DadosBO().VerificaSeExisteArquivoDeConfiguracao();
        }

        private void CheckFiles()
        {

        }

        private void CheckDocumentsFiles(string file)
        {
            documents_extentions.ForEach(extention =>
            {
                if (file.EndsWith(extention.GetEnumDescription()))
                {
                    string source_file = file.Replace($@"{dados.source_dir}\", " ");
                    Console.WriteLine("Moved Document file: {0} to Directory: {1}", source_file, dados.destination_dir_documents);
                    MoveFiles(dados.destination_dir_documents, file, source_file);
                }
            });
        }

        private void CheckImageFiles(string file)
        {
            images_extentions.ForEach(extenction =>
            {
                if (file.EndsWith(extenction.GetEnumDescription()))
                {
                    string source_file = file.Replace($@"{dados.source_dir}\", " ");
                    Console.WriteLine("Moved image file: {0} to Directory: {1}", source_file, dados.destination_dir_image);
                    MoveFiles(dados.destination_dir_image, file, source_file);
                }
            });
        }

        private void MoveFiles(string destination, string pathToMove, string source_file)
        {
            VerifyIfDestinationExist(destination);

            string moveTo = Path.Combine(destination, source_file);

            File.Move(pathToMove, moveTo);
        }

        private void VerifyIfDestinationExist(string destination)
        {
            if (Directory.Exists(destination))
            {
                Console.WriteLine("Directory Exists");
            }
            else
            {
                Directory.CreateDirectory(destination);
                Console.WriteLine(" Create the Directory");
            }
        }
        
    }
}
