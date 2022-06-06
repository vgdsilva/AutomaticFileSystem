using AutomaticDownloadFile.Enuns;
using AutomaticDownloadFile.Utils;
using FileDados.Entidades;


namespace AutomaticDownloadFile.ServiceBO
{
    public class AutomaticFileServiceBO
    {
        private Dados dados;

        private string source_dir;
        private string destination_dir_image;
        private string destination_dir_documents;
        
        private static List<TiposArquivos> images_extentions = new List<TiposArquivos> { TiposArquivos.PNG, TiposArquivos.JPG, TiposArquivos.JPEG };
        private static List<TiposArquivos> documents_extentions = new List<TiposArquivos> { TiposArquivos.DOC, TiposArquivos.PDF, TiposArquivos.DOCX, TiposArquivos.TXT, TiposArquivos.XLS, TiposArquivos.XLSX };

        public AutomaticFileServiceBO()
        {

        }

        public void IniciateFileService()
        {

            source_dir = dados.source_dir;

            var files = from file in Directory.EnumerateFiles(source_dir) select file;
            //Console.WriteLine("Files: {0}", files.Count<string>().ToString());
            //Console.WriteLine("List of Files Moved:");
            foreach (var file in files)
            {
                string source_file = file.Replace($@"{source_dir}\", " ");
                //Console.WriteLine("{0}", fl);

                CheckImageFiles(file);
                CheckDocumentsFiles(file);
            }
        }

        private void CheckDocumentsFiles(string file)
        {
            documents_extentions.ForEach(extention =>
            {
                if (file.EndsWith(Utility.GetDescritionFromEnum(extention)))
                {
                    string source_file = file.Replace($@"{source_dir}\", " ");
                    Console.WriteLine("Moved Document file: {0} to Directory: {1}", source_file, destination_dir_documents);
                    MoveFiles(destination_dir_documents, file, source_file);
                }
            });
        }

        private void CheckImageFiles(string file)
        {
            images_extentions.ForEach(extenction =>
            {
                if (file.EndsWith(Utility.GetDescritionFromEnum(extenction)))
                {
                    string source_file = file.Replace($@"{source_dir}\", " ");
                    Console.WriteLine("Moved image file: {0} to Directory: {1}", source_file, destination_dir_image);
                    MoveFiles(destination_dir_image, file, source_file);
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
