using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticDownloadFile.ServiceBO
{
    public class AutomaticFileServiceBO
    {

        private static string userName = Environment.UserName;

        private static string source_dir = @$"C:\Users\{userName}\Downloads";
        private static string destination_dir_image = @$"C:\Users\{userName}\Pictures\";
        private static string destination_dir_documents = @$"C:\Users\{userName}\Documents\";
        
        private static List<string> images_extentions = new List<string> { ".jpg", ".png" };
        private static List<string> documents_extentions = new List<string> { ".doc", ".pdf", ".docx", ".txt", ".xls", ".xlsx" };

        public AutomaticFileServiceBO()
        {

        }

        public void IniciateFileService()
        {
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
                if (file.EndsWith(extention))
                {
                    string source_file = file.Replace($@"{source_dir}\", " ");
                    //Console.WriteLine("Moved Document file: {0} to Directory: {1}", source_file, destination_dir_documents);
                    MoveFiles(destination_dir_documents, file, source_file);
                }
            });
        }

        private void CheckImageFiles(string file)
        {
            images_extentions.ForEach(extenction =>
            {
                if (file.EndsWith(extenction))
                {
                    string source_file = file.Replace($@"{source_dir}\", " ");
                    //Console.WriteLine("Moved image file: {0} to Directory: {1}", source_file, destination_dir_image);
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
