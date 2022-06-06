using Topshelf;

namespace AutomaticFileService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<Service.AutomaticFileService>(s =>
                {
                    s.ConstructUsing(auto => new Service.AutomaticFileService());
                    s.WhenStarted(auto => auto.Start());
                    s.WhenStopped(auto => auto.Stop());
                });

                x.RunAsLocalSystem();

                x.SetServiceName("AutomaticDownloadFileSystem");
                x.SetDisplayName("Automatic Download Files System");
                x.SetDescription("Service Description");
            });

            int exitCodevalue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodevalue;
        }
    }
}