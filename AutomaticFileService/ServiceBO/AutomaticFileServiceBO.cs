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

        public void IniciateFileService()
        {
            dados = new DadosBO().GetDadosFromConfiguration();

            var files = from file in Directory.EnumerateFiles(dados.source_dir) select file;
            foreach (var file in files)
            {
                foreach (var paths in dados.PathDados)
                {
                    string source_file = file.Replace($@"{dados.source_dir}\", " ");

                    CheckFiles(file, paths.name_contains, paths.destination_dir, source_file, paths.extencions);
                }
            }
        }

        public void VerificarArquivoDeConfiguracao()
        {
            new DadosBO().VerificaSeExisteArquivoDeConfiguracao();
        }
        private void CheckFiles(string file, string Content, string destination, string source_file, List<TiposArquivos> extensoes)
        {
            if (Content != null && Content != "")
                CheckFilesByNameContent(file, Content, destination, source_file);
            else
                CheckFilesByTypeExtensions(file, extensoes, destination, source_file);
        }

        private void CheckFilesByTypeExtensions(string file, List<TiposArquivos> extensoes, string destination, string source_file)
        {
            extensoes.ForEach(e =>
            {
                if (file.EndsWith(e.GetEnumDescription()))
                {
                    MoveFiles(destination, file, source_file);
                }
            });
        }

        private void CheckFilesByNameContent(string file, string Content, string destination, string source_file)
        {
            if (!string.IsNullOrEmpty(Content) && file.Contains(Content))
            {
                MoveFiles(destination, file, source_file);
            }
        }

        

        //private void CheckDocumentsFiles(string file)
        //{
        //    documents_extentions.ForEach(extention =>
        //    {
        //        if (file.EndsWith(extention.GetEnumDescription()))
        //        {
        //            string source_file = file.Replace($@"{dados.source_dir}\", " ");
        //            Console.WriteLine("Moved Document file: {0} to Directory: {1}", source_file, dados.destination_dir_documents);
        //            MoveFiles(dados.destination_dir_documents, file, source_file);
        //        }
        //    });
        //}

        //private void CheckImageFiles(string file)
        //{
        //    images_extentions.ForEach(extenction =>
        //    {
        //        if (file.EndsWith(extenction.GetEnumDescription()))
        //        {
        //            string source_file = file.Replace($@"{dados.source_dir}\", " ");
        //            Console.WriteLine("Moved image file: {0} to Directory: {1}", source_file, dados.destination_dir_image);
        //            MoveFiles(dados.destination_dir_image, file, source_file);
        //        }
        //    });
        //}

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
